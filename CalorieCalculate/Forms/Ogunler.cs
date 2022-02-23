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
        private int user;
        private Repast repast;
        public Ogunler()
        {
            InitializeComponent();
            //ogunler birer picturebox. üc öğün için secilen ogun formu olusturuldu hangi pb ye tıklanırsa formun texti o olur. tarih uyumluluğu sorgulanarak datadan veriler cekilir ve datagridview'da ekrana yazılır.
            //örnek : kahvaltı tag 1, ögle yemeği tag 2, aksam yemegi tag 3, geri tuşu tag 4, ptofil tag 5. Switch case yapısıyla tıklanan ifadeyi cek ve işlem yap.

        }

        public Ogunler(int user)
        {
            InitializeComponent();
            this.user = user;
        }

        //oop icin yapı olusturuldugunda acılacak form isimleri veri olarak metod icerisinde gönderilecek.
        private void Interface_Click(object sender, EventArgs e)
        {
            Button pb = (Button)sender;
            Form frm = default;
            OgunEkle(pb);
            switch (pb.Tag.ToString())
            {
                case "1":
                    frm = new SecilenOgun(repast);
                    break;
                case "2":
                    frm = new SecilenOgun(repast);
                    break;
                case "3":
                    frm = new SecilenOgun(repast);
                    break;
                case "4":
                    this.Close();
                    break;
                //case "5":
                //    frm = new Profil();    profil sayfası olusturulunca aktif olacak.
                //    break;
            }
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
        
        private void OgunEkle(Button pb)
        {
            using (DatabaseContext db = new DatabaseContext())
            {
                repast = new Repast()
                {
                    RepastName = pb.Text,
                    UserId = user,
                    Date = DateTime.Now
                };
                db.Repasts.Add(repast);
                db.SaveChanges();
            }
        }
    }
}
