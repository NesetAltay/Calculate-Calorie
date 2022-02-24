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
        private static DatabaseContext _db;
        /// <summary>
        /// Uygulamaya giriş yapan kullanıcının bilgilerini alır
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static User GetUser(string email, string password)
        {
            _db = DatabaseContext.GetInstance();
            User user = _db.Users.Where(x => x.Email.Equals("altayneset@gmail.com") && x.Password.Equals("12345Neset"))
                    .Select(x => x).FirstOrDefault();
            return user;
        }
        /// <summary>
        /// Oturum açan kullanıcı bilgilerini alır
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static UserInformation GetInformation(int userId)
        {
            _db = DatabaseContext.GetInstance();
            UserInformation user = _db.UserInformations.Where(x => x.Id == userId).FirstOrDefault();
            return user;
        }
        public static List<Challenge> GetChallenge()
        {
            _db = DatabaseContext.GetInstance();
            List<Challenge> result = _db.RepastMeals.GroupBy(x => new { x.Repast.RepastName, x.Repast.User.UserInformation.FirstName})
                .Select(x => new Challenge { UserName = x.Key.FirstName, Repast = x.Key.RepastName, TotalCalorie = x.Sum(y => y.Meal.Calorie)})
                .OrderBy(x => x.TotalCalorie).ToList();
            return result;
        }
        public static void MostPopularMeal(User user)
        {
            //_db = DatabaseContext.GetInstance();
            //var result = _db.RepastMeals.Where(x => x.Repast.UserId.Equals(user.Id))
            //    .GroupBy(x => x.Repast.RepastName)
        }
    }
}
