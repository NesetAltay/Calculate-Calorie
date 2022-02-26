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
        public static UserInformation GetInformation(int userId)
        {
            UserInformation user = _db.UserInformations.Where(x => x.Id == userId).FirstOrDefault();
            return user;
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
                          .Where(x => x.Repast.Date >= x.Repast.Date.AddDays(-7) && x.Repast.Date.Equals(DateTime.Today))
                          .GroupBy(x => new { x.Repast.RepastName, x.Repast.User.UserInformation.FirstName })
                          .Select(x => new Challenge() { UserName = x.Key.FirstName, RepastName = x.Key.RepastName, TotalCalorie = x.Sum(y => y.Meal.Calorie * y.EatenPortion) })
                           .OrderBy(x => x.TotalCalorie).ToList();
            }
            dgv.DataSource = result;
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
                        .Select(x => new MostPopularDTO() { RepastName = x.Key.RepastName, MealName = x.Key.MealName, Total = x.Key.MealName.Sum(y => y) }).ToList();
            }
                dgvSorgu.DataSource = result;
           
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
                result = _db.RepastMeals.Where(x => x.Repast.User.Id.Equals(user.Id))
                        .GroupBy(x => x.Meal.MealName).Select(x => new BestMealDTO() { MealName = x.Key, TotalMeal = x.Key.Sum(y => y) })
                        .OrderByDescending(x => x).ToList();
            }
                dgvSorgu.DataSource = result;
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
                   .GroupBy(x => new { x.Repast.RepastName, x.Meal.Calorie})
                   .Select(x => new DailyDTO() { RepastName = x.Key.RepastName, 
                       TotalCalorie = x.Sum(y => y.Meal.Calorie * y.EatenPortion) }).ToList(); 
            }
            dgv.DataSource = result;
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
                result = _db.RepastMeals.Where(x => x.Repast.User.Id.Equals(user.Id) && x.Repast.Date.Day.Equals(DateTime.Today.Day) && x.Repast.Date.Month.Equals(DateTime.Today.Month))
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
                .Select(x => new YemekDTO() {Id = x.Id, MealName = x.MealName, Calorie = x.Calorie, Description = x.MealDescription }).ToList();
            return new BindingList<YemekDTO> (yemekler);
        }
        /// <summary>
        /// Kullanıcının öğünlerde yediği yemeklerin raporunu getirir
        /// </summary>
        /// <param name="user"></param>
        /// <param name="dgv"></param>
        /// <param name="repast"></param>
        public static void RepastRaport(User user, DataGridView dgv, string repast)
        {
            List<YenenYemekDTO> dailyEat = default;
            if (StringExtension.AnyDaily(user))
            {
                dailyEat = _db.RepastMeals
               .Where(x => x.Repast.User.Id.Equals(user.Id) && x.Repast.Date.Day.Equals(DateTime.Today.Day) && x.Repast.RepastName.Equals(repast)&& x.Repast.Date.Month.Equals(DateTime.Today.Month)) 
               .Select(x => new YenenYemekDTO { RepastName = x.Repast.RepastName, MealName = x.Meal.MealName }).ToList(); 
            }
            dgv.DataSource = dailyEat;
        }
    }
}
