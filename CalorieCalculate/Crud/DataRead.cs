using CalorieCalculate.Extensions;
using CalorieCalculate.Model.Data;
using CalorieCalculate.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculate.Crud
{
    public static class DataRead
    {
        private static DatabaseContext _db = DatabaseContext.GetInstance();
       

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
        public static List<Challenge> GetChallenge()
        {
            // Zaman ayarlaması yapılacak
            List<Challenge> result = _db.RepastMeals
                .GroupBy(x => new { x.Repast.RepastName, x.Repast.User.UserInformation.FirstName})
                .Select(x => new Challenge() { UserName = x.Key.FirstName, Repast = x.Key.RepastName, TotalCalorie = x.Sum(y => y.Meal.Calorie*y.EatenPortion)})
                .OrderBy(x => x.TotalCalorie).ToList();
            return result;
        }
        /// <summary>
        /// Kullanıcının öğün bazlı en çok yediği yemek raporu
        /// </summary>
        /// <param name="user"></param>
        public static List<MostPopularDTO> MostPopularMeal(User user)
        {
            List<MostPopularDTO> result = _db.RepastMeals.Where(x => x.Repast.UserId.Equals(user.Id))
                .GroupBy(x => new { x.Repast.RepastName, x.Meal.MealName })
                .Select(x => new MostPopularDTO() { RepastName = x.Key.RepastName, MealName = x.Key.MealName, Total = x.Key.MealName.Sum(y => y) }).ToList();
            return result;
        }
        /// <summary>
        /// Kullanıcının en çok tercih ettiği yemek raporu
        /// </summary>
        /// <param name="user"></param>
        public static List<BestMealDTO> BestMeal(User user)
        {
            List<BestMealDTO> result = _db.RepastMeals.Where(x => x.Repast.UserId.Equals(user.Id))
                .GroupBy(x => x.Meal.MealName).Select(x => new BestMealDTO() { MealName = x.Key, TotalMeal = x.Key.Sum(y => y)})
                .OrderByDescending(x => x).ToList();
            return result;
        }
        /// <summary>
        /// Kullanıcının günlük öğün bazlı almış olduğu toplam kalori raporu
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static List<DailyDTO> DailyRaport(User user)
        {
            List<DailyDTO> result = _db.RepastMeals.Where(x => x.Repast.UserId.Equals(user.Id) && x.Repast.Date.Day.Equals(DateTime.Today))
                .GroupBy(x => new { x.Repast.RepastName, x.Meal.Calorie })
                .Select(x => new DailyDTO() { RepastName = x.Key.RepastName, TotalCalorie = x.Sum(y => y.Meal.Calorie * y.EatenPortion) }).ToList();
            return result;
        }
        /// <summary>
        /// Kullanıcının günlük almış olduğu toplam kolri raporu
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static double DailyTotalCalorie(User user)
        {
            double result = _db.RepastMeals.Where(x => x.Repast.UserId.Equals(user.Id) && x.Repast.Date.Day.Equals(DateTime.Today))
                .Select(x => x.EatenPortion * x.Meal.Calorie).Sum();
            return result;
        }
    }
}
