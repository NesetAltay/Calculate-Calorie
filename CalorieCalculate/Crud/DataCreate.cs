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
    public class DataCreate
    {
        User user;
        UserInformation userInformation;

        public void CreateUser(string email, string password)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                user = new User()
                {
                    Email = email,
                    Password = password
                };
                db.Users.Add(user);
                db.SaveChanges();
            }

        }
        public void CreateUserInformation(string name, string lastname, string height, string weight, DateTime dt)
        {
            using (DatabaseContext db = new DatabaseContext())
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
                db.UserInformations.Add(userInformation);
                db.SaveChanges();

            }
        }
    }
}
