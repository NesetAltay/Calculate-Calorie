using CalorieCalculate.Model.Data;
using CalorieCalculate.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculate.Forms
{
    public partial class SecilenOgun : Form
    {
        private Repast repast;

        public SecilenOgun()
        {
            InitializeComponent();

        }

        public SecilenOgun(Repast repast)
        {
            InitializeComponent();
            this.repast = repast;
            lblOgunAdi.Text = repast.RepastName;
        }

        private void Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Tag.ToString())
            {
                case "1":
                    YemekListele();
                    break;
            }
        }

        private void YemekListele()
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                var yemekler = db.Meals.ToList();
                var filter = yemekler.Select(x => new YemekDTO() { MealName = x.MealName, Calorie = x.Calorie, Description = x.MealDescription, MealType = x.TypeMealId }).ToList();
                //List<Meal> meals = db.Meals.ToList();
                dgvOgun.DataSource = yemekler;
            }
        }
    }
}
