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
    public partial class Profil : Form
    {
        
        public Profil()
        {
            InitializeComponent();
        }
        
        private User user;
        private static DatabaseContext _db = BaseContext.GetInstance();
        /// <summary>
        /// Aktif kullanıcının bilgilerini alan sorgular.
        /// </summary>
        public Profil(User user)
        {
            this.user = user;

            InitializeComponent();

            lblAd1.Text = _db.UserInformations.Where(x => x.Id == x.User.Id)
                .Select(x => x.FirstName).FirstOrDefault().ToString();
            lblSoyad1.Text = _db.UserInformations.Where(x => x.Id == x.User.Id)
                .Select(x => x.LastName).FirstOrDefault().ToString();
            lblDogumTarihi1.Text = _db.UserInformations.Where(x => x.Id == x.User.Id)
                .Select(x => x.BirthDate).FirstOrDefault().ToString();
            lblBoy1.Text = _db.UserInformations.Where(x => x.Id == x.User.Id)
                .Select(x => x.Height).FirstOrDefault().ToString();
            lblKilo1.Text = _db.UserInformations.Where(x => x.Id == x.User.Id)
                .Select(x => x.Weight).FirstOrDefault().ToString();
        }
    }
}
