namespace CalorieCalculate.Crud
{
    public class YenenYemekDTO
    {
        public int Id { get; set; }
        public string RepastName { get; set; } = "Boş";
        public string MealName { get; set; } = "Boş";
        public double TotalCalorie { get; internal set; }
    }
}