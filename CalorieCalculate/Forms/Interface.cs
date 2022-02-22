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
        public Interface()
        {
            InitializeComponent();
        }

        private void Interface_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            Form frm = default;
            switch (pb.Tag.ToString())
            {
                case "1":
                    //linq sorguları çalışacak aktif üyenin gün içerisinde yediği öğünler ait oldukları öğün listesine aktarılacak.
                    frm = new Ogunler();
                    break;
                case "2":
                    //
                    frm = new Raporlar();
                    break;
                case "3":
                   // BedenKitleHesapla(height,weight);
                   //cıkan sonucu bedenkitle formunda sonuc labelinin textine yazdır.
                    frm = new BedenKitle();
                    break;
            }
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void BedenKitleHesapla(double height, double weight)
        {
            //kilo ve boy parametre olarak verilecek hesaplama yapılacak.
        }
    }
}
