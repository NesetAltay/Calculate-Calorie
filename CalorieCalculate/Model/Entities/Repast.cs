using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculate.Model.Entities
{
   public class Repast : BaseProperty
    {
        public string RepastName { get; set; }
        public DateTime Date { get; set; }

        #region Navigation

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<RepastMeal> RepastMeals { get; set; }
    
        #endregion
    }
}
