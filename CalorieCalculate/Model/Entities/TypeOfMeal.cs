using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculate.Model.Entities
{
   public class TypeOfMeal : BaseProperty
    {
        public string MealType { get; set; }

        #region Navigation

        public virtual ICollection<Meal> Meals { get; set; }
        #endregion
    }
}
