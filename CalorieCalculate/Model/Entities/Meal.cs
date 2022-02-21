using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculate.Model.Entities
{
    public class Meal : BaseProperty
    {
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public double Calorie { get; set; }

        #region Navigation

        public int TypeMealId { get; set; }
        public virtual TypeOfMeal TypeOfMeal { get; set; }

        public virtual ICollection<RepastMeal> RepastMeals { get; set; }

        #endregion
    }
}
