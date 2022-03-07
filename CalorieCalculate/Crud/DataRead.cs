using CalorieCalculate.Extensions;
using CalorieCalculate.Forms;
using CalorieCalculate.Model.Data;
using CalorieCalculate.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculate.Crud
{
    public static class DataRead
    {
        private static DatabaseContext _db = BaseContext.GetInstance();

        /// <summary>
        /// Uygulamaya giriş yapan kullanıcının bilgilerini alır
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static User GetUser(string email, string password)
        {
            User user = _db.Users.Where(x => x.Email.Equals(email) && x.Password.Equals(password))
                    .Select(x => x).FirstOrDefault();
            return user;
        }
        /// <summary>
        /// Oturum açan kullanıcı kişisel bilgilerini alır
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static UserInformation GetInformation(User user)
        {
            UserInformation information = _db.UserInformations.Where(x => x.Id == user.Id).FirstOrDefault();
            return information;
        }
        /// <summary>
        /// Kullanıcıların yediğiği yemeklerin ve aldıkları kalorilerin karşılaştırılması
        /// </summary>
        /// <returns></returns>
        public static void GetChallenge(DataGridView dgv)
        {
            List<Challenge> result = default;
            if (StringExtension.AnyChallenge())
            {
                result = _db.RepastMeals
                          .Where(x => x.Repast.Date.Day.Equals(DateTime.Today.Day)
                          && x.Repast.Date >= x.Repast.Date.AddDays(-7))
                          .Select(x => new Challenge()
                          {
                              UserName = x.Repast.User.UserInformation.FirstName,
                              RepastName = x.Repast.RepastName,
                              TotalCalorie = (x.EatenPortion * x.Meal.Calorie)
                          })
                          .ToList();
                dgv.DataSource = new BindingList<Challenge>(result);
            }

        }
        /// <summary>
        /// Kullanıcının öğün bazlı en çok yediği yemek raporu
        /// </summary>
        /// <param name="user"></param>
        public static void MostPopularMeal(User user, DataGridView dgvSorgu)
        {
            List<MostPopularDTO> result = default;
            if (StringExtension.AnyMeal(user))
            {
                result = _db.RepastMeals.Where(x => x.Repast.User.Id.Equals(user.Id))
                        .GroupBy(x => new { x.Repast.RepastName, x.Meal.MealName })
                        .Select(x => new MostPopularDTO()
                        {
                            RepastName = x.Key.RepastName,
                            MealName = x.Key.MealName,
                            Total = x.Key.MealName.Count()
                        }).ToList();
                dgvSorgu.DataSource = new BindingList<MostPopularDTO>(result);
            }


        }
        /// <summary>
        /// Kullanıcının en çok tercih ettiği yemek raporu
        /// </summary>
        /// <param name="user"></param>
        public static void BestMeal(User user, DataGridView dgvSorgu)
        {
            List<BestMealDTO> result = default;
            if (StringExtension.AnyMeal(user))
            {
                result = _db.RepastMeals.Where(x => x.Repast.User.Id.Equals(user.Id)).GroupBy(x => x.Meal.MealName)
                    .Select(x => new BestMealDTO()
                    {
                        MealName = x.Key,
                        TotalMeal = x.Key.Count()
                    }).ToList();
                dgvSorgu.DataSource = new BindingList<BestMealDTO>(result);
            }

        }
        /// <summary>
        /// Kullanıcının günlük öğün bazlı almış olduğu toplam kalori raporu
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static void DailyRaport(User user, DataGridView dgv)
        {
            List<DailyDTO> result = default;
            if (StringExtension.AnyDaily(user))
            {
                result = _db.RepastMeals.Where(x => x.Repast.User.Id.Equals(user.Id) && x.Repast.Date.Day.Equals(DateTime.Today.Day) && x.Repast.Date.Month.Equals(DateTime.Today.Month))
                   .Select(x => new DailyDTO()
                   {
                       RepastName = x.Repast.RepastName,
                       TotalCalorie = x.EatenPortion * x.Meal.Calorie
                   }).ToList();
                dgv.DataSource = new BindingList<DailyDTO>(result);
            }

        }
        /// <summary>
        /// Kullanıcının günlük almış olduğu toplam kolri raporu
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static double DailyTotalCalorie(User user, DataGridView dgvSorgu)
        {
            double result = default;
            if (StringExtension.AnyDaily(user))
            {
                result = _db.RepastMeals.Where(x => x.Repast.User.Id.Equals(user.Id)
                && x.Repast.Date.Day.Equals(DateTime.Today.Day) && x.Repast.Date.Month.Equals(DateTime.Today.Month))
                       .Select(x => x.EatenPortion * x.Meal.Calorie).Sum();
            }
            dgvSorgu.DataSource = result;
            return result;
        }
        /// <summary>
        /// Database'de kayıtlı yemek listesini getirir
        /// </summary>
        /// <param name="dgv"></param>
        public static BindingList<YemekDTO> YemekListele()
        {
            var yemekler = _db.Meals
                .Select(x => new YemekDTO() { Id = x.Id, MealName = x.MealName, Calorie = x.Calorie }).ToList();
            return new BindingList<YemekDTO>(yemekler);
        }
        /// <summary>
        /// Kullanıcının öğünlerde yediği yemeklerin raporunu getirir
        /// </summary>
        /// <param name="user"></param>
        /// <param name="dgv"></param>
        /// <param name="repast"></param>
        public static List<YenenYemekDTO> RepastRaport(User user, DataGridView dgv, string repast)
        {
            List<YenenYemekDTO> dailyEat = null;
            if (StringExtension.AnyDaily(user))
            {
                dailyEat = _db.RepastMeals
               .Where(x => x.Repast.User.Id.Equals(user.Id) && x.Repast.Date.Day.Equals(DateTime.Today.Day) && x.Repast.RepastName.Equals(repast) && x.Repast.Date.Month.Equals(DateTime.Today.Month))
               .Select(x => new YenenYemekDTO
               {
                   Id = x.MealId,
                   MealName = x.Meal.MealName,
                   RepastName = x.Repast.RepastName,
                   TotalCalorie = x.EatenPortion * x.Meal.Calorie,
                   EatenPortion = (float)x.EatenPortion,
                   Image = x.MealImage
               }).ToList();
            }
            return dailyEat;
        }
        public static string MealDescription(int id)
        {
            string description = _db.Meals.Where(x => x.Id.Equals(id)).Select(x => x.MealDescription).FirstOrDefault();
            return description;
        }
        public static string MealImage(int id)
        {
            string image = _db.RepastMeals.Where(x => x.MealId.Equals(id)).Select(x => x.MealImage).FirstOrDefault();
            return image;
        }
    }
}
