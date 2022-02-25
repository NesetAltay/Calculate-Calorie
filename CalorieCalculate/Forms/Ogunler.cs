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
    public partial class Ogunler : Form
    {
        private User user;
        public Ogunler()
        {
            InitializeComponent();
        }

        public Ogunler(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        //oop icin yapı olusturuldugunda acılacak form isimleri veri olarak metod icerisinde gönderilecek.
        private void Interface_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Tag.ToString() == "4") this.Close();

            //else if(btn.Tag.ToString() == "5")
            //case "5":
            //    frm = new Profil();    profil sayfası olusturulunca aktif olacak.
            //    break;
            else
            {
                Repast repast = DataCreate.Create(btn, user);
                Form frm = default;
                frm = new SecilenOgun(repast);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }
    }
}
