namespace CalorieCalculate.Forms
{
    public class YemekDTO
    {
        public YemekDTO()
        {

        }
        public int Id { get; set; }
        public int Adet { get; set; }
        public string MealName { get; set; } = "Boş";
        public double Calorie { get; set; } = 0;
        public string Description { get; set; } = "Boş";
    }
}