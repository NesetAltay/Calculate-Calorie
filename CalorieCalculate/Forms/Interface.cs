using CalorieCalculate.Model.Data;
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
        private int user;

        public Interface()
        {
            InitializeComponent();
        }

        public Interface(int user)
        {
            this.user = user;
        }

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
                    //Database tarafından kişinin kilo ve boy bilgileri çekilerek beden kitle indeksi hesaplanır.Bu sonuc beden kitle indeksi tablosuna aktarılır.
                    OturumAc oturum = new OturumAc();
                    using (DatabaseContext context = new DatabaseContext())
                    {

                        var result = context.UserInformations.Where(x => x.Id == user).Select(x=> new {y = x.Weight, z = x.Height}).FirstOrDefault();
                        BedenKitle bd = new BedenKitle();
                        bd.lblSonuc.Text = BedenKitleHesapla(result.z,result.y).ToString();
                        frm = new BedenKitle();
                        break;
                    }

            }
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private decimal BedenKitleHesapla(decimal height, decimal weight)
        {
            decimal x;
            decimal vki;
            x = height * height;
            vki = weight / x;
            return vki;
        }
    }
}
