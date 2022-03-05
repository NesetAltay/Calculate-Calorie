
namespace CalorieCalculate.Crud
{
    public class YenenYemekDTO 
    {
        public int Id { get; set; }
        public string RepastName { get; set; } 
        public string MealName { get; set; } 
        public double TotalCalorie { get; internal set; }
        public float EatenPortion { get; internal set; }
    }
}