using CalorieCalculate.Crud;
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
    public partial class SecilenRapor : Form
    {
        private string btnTag;
        private User user;

        public SecilenRapor()
        {
            InitializeComponent();
        }

        public SecilenRapor(string v, User user)
        {
            InitializeComponent();
            this.btnTag = v;
            this.user = user;
        }
        
        private void SecilenRapor_Load(object sender, EventArgs e)
        {
            switch (btnTag)
            {
                case "1":
                    btnSorgu1.Text = "Öğün Bazlı Kalori Hesabı";
                    btnSorgu1.Tag = "1";
                    btnSorgu2.Text = "Günlük Toplam Kalori";
                    btnSorgu2.Tag = "2";
                    break;
                case "2":
                    btnSorgu1.Text = "Kıyas Raporu";
                    btnSorgu1.Tag = "3";
                    btnSorgu2.Enabled = false;
                    break;
                case "3":
                    btnSorgu1.Text = "Öğün Bazlı En Çok Yenen Yemek";
                    btnSorgu1.Tag = "4";
                    btnSorgu2.Text = "En çok Yenen Yemekler";
                    btnSorgu2.Tag = "5";
                    break;
            }
        }

        private void Click(object sender, EventArgs e)
        {
            if(dgvSorgu.Rows.Count!=0)
            dgvSorgu.Rows.Clear();
            Button btn = (Button)sender;
            switch (btn.Tag.ToString())
            {
                case "1":
                   DataRead.DailyRaport(user, dgvSorgu);
                    break;
                case "2":
                   DataRead.DailyTotalCalorie(user, dgvSorgu);
                    break;
                case "3":
                     DataRead.GetChallenge(dgvSorgu);
                    break;
                case "4":
                   DataRead.MostPopularMeal(user, dgvSorgu);
                    break;
                case "5":
                   DataRead.BestMeal(user, dgvSorgu);
                    break;
                case "9":
                    this.Close();
                    break;
            }
        }
    }
}
