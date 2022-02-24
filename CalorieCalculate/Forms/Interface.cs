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
    public partial class Interface : Form
    {
        private User user;
        public Interface()
        {
            InitializeComponent();
        }
        public Interface(User user)
        {
            InitializeComponent();
            this.user = user;
        }
        /// <summary>
        /// Interface sayfasında yapılan seçim doğrultusunda açılacak formu belirleyen case yapısı
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Interface_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Form frm = default;
            switch (pb.Tag.ToString())
            {
                case "1":
                    frm = new Ogunler(user);
                    break;
                case "2":
                    frm = new Raporlar(user);
                    break;
                case "3":
                    var result = DataRead.GetInformation(user.Id);
                    frm = new BedenKitle(BedenKitleHesapla(result.Height, result.Weight).ToString());
                    break;
            }
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
        /// <summary>
        /// Beden kitle indexi hesaplama
        /// </summary>
        /// <param name="height"></param>
        /// <param name="weight"></param>
        /// <returns></returns>
        private decimal BedenKitleHesapla(decimal height, decimal weight)
        {
            decimal x;
            decimal vki;
            x = (height * height) / 10000;
            vki = weight / x;
            return Math.Round(vki, 2);
        }
    }
}
