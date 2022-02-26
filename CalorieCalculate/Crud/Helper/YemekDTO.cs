namespace CalorieCalculate.Forms
{
    public class YemekDTO
    {
        public YemekDTO()
        {

        }
        public int Id { get; set; }
        public int Adet { get; set; }
        public string MealName { get; set; } 
        public double Calorie { get; set; } 
        public string Description { get; set; } 
    }
}