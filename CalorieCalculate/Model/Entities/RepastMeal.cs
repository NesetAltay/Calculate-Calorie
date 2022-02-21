using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieCalculate.Model.Entities
{
    public class RepastMeal 
    {
        public double EatenPortion { get; set; }

        // 1. yöntem bir path tutma
        // 2. yöntem datayı binary türüne dönüştürüp sql e bu data atılabilir

        public string MealImage { get; set; }

        public int RepastId { get; set; }
        public Repast Repast { get; set; }

        public int MealId { get; set; }
        public Meal Meal { get; set; }

    }
}
