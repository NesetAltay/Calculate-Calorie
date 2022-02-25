using CalorieCalculate.Crud;
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
        private User user;
        public SecilenOgun()
        {
            InitializeComponent();
        }

        public SecilenOgun(Repast repast, User user)
        {
            InitializeComponent();
            this.repast = repast;
            this.user = user;
            lblOgunAdi.Text = repast.RepastName;
            //DatabaseContext db = BaseContext.GetInstance();


            //var result = db.RepastMeals.Where(x => x.Repast.Date.Equals(DateTime.Today) && x.Repast.UserId.Equals(user.Id))
            //    .GroupBy(x => new { x.Repast })
            //    .Select(x => new { RepastName = x.Key.Repast.RepastName, Meals = x.Key.Repast.RepastMeals}).ToList();
        }

        private void Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Tag.ToString())
            {
                case "1":
                    DataRead.YemekListele(dgvOgun);
                    break;
            }
        }
    }
}
