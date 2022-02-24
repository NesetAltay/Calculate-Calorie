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
        private static DatabaseContext _db = DatabaseContext.GetInstance();
        private static User user;
        private static UserInformation userInformation;
        /// <summary>
        /// Yeni kullanıcı verisi oluşturur
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        public static void Create(string email, string password)
        {
            user = new User()
            {
                Email = email,
                Password = password
            };
            _db.Users.Add(user);
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
            userInformation = new UserInformation()
            {
                Id = user.Id,
                FirstName = name,
                LastName = lastname,
                Height = decimal.Parse(height),
                Weight = decimal.Parse(weight),
                BirthDate = dt
            };
            _db.UserInformations.Add(userInformation);
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
            Repast repast = new Repast()
            {
                RepastName = btn.Text,
                UserId = user.Id,
                Date = DateTime.Now
            };
            _db.Repasts.Add(repast);
            _db.SaveChanges();
            return repast;
        }
    }
}
