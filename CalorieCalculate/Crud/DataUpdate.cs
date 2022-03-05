using CalorieCalculate.Model.Data;
using CalorieCalculate.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculate.Crud
{
    public static class DataUpdate
    {
        private static DatabaseContext _db = BaseContext.GetInstance();
        public static void Update(User user, Repast repast, YenenYemekDTO meal)
        {
            double porsiyon = double.Parse(meal.EatenPortion.ToString());

            var result = _db.RepastMeals.FirstOrDefault(x => x.Repast.User.Id.Equals(user.Id)
            && x.Repast.RepastName.Equals(repast.RepastName) && x.Meal.MealName.Equals(meal.MealName)
            && x.Repast.Date.Day.Equals(DateTime.Today.Day) && x.Repast.Date.Month.Equals(DateTime.Today.Month));

            result.EatenPortion = porsiyon;
            _db.SaveChanges();
        }
    }
}
