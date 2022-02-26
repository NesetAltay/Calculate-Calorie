using CalorieCalculate.Crud;
using CalorieCalculate.Model.Data;
using CalorieCalculate.Model.Entities;
using CalorieCalculate.Properties;
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
            DataRead.RepastRaport(user, dgvOgun, repast.RepastName);
        }
        // DataGridView den seçilen yemekler RepastMeal a eklenecek
        private void Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Tag.ToString())
            {
                case "1":
                    DataRead.YemekListele(dgvOgun);
                    break;

                    // Resim ekleme yapısı oluşturulduğunda click event içerisine yazılacak kod, resim yolu aynı zamanda RepastMeals içerisinde Image kısmına aktarılarak 
                    /*
                    pbYemek.SizeMode = PictureBoxSizeMode.StretchImage;
                    ofdPictureFile.ShowDialog();
                    string fileName = ofdPictureFile.FileName;
                    pbYemek.ImageLocation = fileName;
                    */
            }
        }
        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
