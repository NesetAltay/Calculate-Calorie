using CalorieCalculate.Extensions;
using CalorieCalculate.Model.Data;
using CalorieCalculate.Model.Entities;
using KLCToolbox.KLCControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculate.Crud
{
    public static class DataCreate
    {
        private static DatabaseContext _db = BaseContext.GetInstance();
        private static User _user;
        private static UserInformation _userInformation;
        private static Repast _repast;
        private static RepastMeal _repastMeal;
        /// <summary>
        /// Yeni kullanıcı verisi oluşturur
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public static void Create(string email, string password)
        {
            _user = new User()
            {
                Email = email,
                Password = password
            };
            _db.Users.Add(_user);
            _db.SaveChanges();
        }
        /// <summary>
        /// Yeni kullanıcının kişisel bilgilerini oluşturur
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <param name="dt"></param>
        public static void Create(string name, string lastname, string height, string weight, DateTime dt)
        {
            _userInformation = new UserInformation()
            {
                Id = _user.Id,
                FirstName = name,
                LastName = lastname,
                Height = decimal.Parse(height),
                Weight = decimal.Parse(weight),
                BirthDate = dt
            };
            _db.UserInformations.Add(_userInformation);
            _db.SaveChanges();
        }
        /// <summary>
        /// Kullanıcının yaptığı seçim doğrultusunda öğün datası oluşturur
        /// </summary>
        /// <param name="btn"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        public static Repast Create(Button btn, User user)
        {
            _repast = new Repast()
            {
                RepastName = btn.Text,
                UserId = user.Id,
                Date = DateTime.Now
            };
            _db.Repasts.Add(_repast);
            _db.SaveChanges();
            return _repast;
        }
        /// <summary>
        /// Kullanıcının yaptığı öğün ve yemek seçimlerini oluşturur
        /// </summary>
        /// <param name="repast"></param>
        /// <param name="meal"></param>
        /// <param name="portion"></param>
        /// <param name="image"></param>
        public static void Create(Repast repast, Meal meal, double portion = 0, string image = null)
        {
            _repastMeal = new RepastMeal()
            {
                EatenPortion = portion,
                MealImage = image,
                RepastId = repast.Id,
                MealId = meal.Id
            };
            _db.RepastMeals.Add(_repastMeal);
            _db.SaveChanges();
        }
    }
}
