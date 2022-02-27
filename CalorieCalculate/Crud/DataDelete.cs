using CalorieCalculate.Model.Data;
using CalorieCalculate.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculate.Crud
{
    public static class DataDelete
    {
        private static DatabaseContext _db = BaseContext.GetInstance();

        public static void Delete(User user)
        {
            var result = _db.Users.FirstOrDefault(x => x.Id.Equals(user.Id));
            var result1 = _db.UserInformations.FirstOrDefault(x => x.Id.Equals(user.Id));
            _db.Users.Remove(result);
            _db.UserInformations.Remove(result1);
        }
        public static void Delete(Repast repast)
        {
            var result = _db.Repasts.FirstOrDefault(x => x.Id.Equals(repast.Id));
            var result1 = _db.RepastMeals.Where(x => x.RepastId.Equals(repast.Id)).Select(x => x).ToList();
            _db.Repasts.Remove(result);
            for (int i = 0; i < result1.Count; i++)
            {
                _db.RepastMeals.Remove(result1[i]);
            }
        }
        public static void Delete(Meal meal, Repast repast)
        {
            var result = _db.RepastMeals.FirstOrDefault(x => x.Repast.Id.Equals(repast.Id) && x.Meal.Id.Equals(meal.Id));
            _db.RepastMeals.Remove(result);
        }
    }
}
