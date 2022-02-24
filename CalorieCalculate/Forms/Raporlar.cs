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
    public partial class Raporlar : Form
    {
        private User user;

        public Raporlar()
        {
            InitializeComponent();
        }

        public Raporlar(User user)
        {
            this.user = user;
            //List<Challenge> challenge = DataRead.GetChallenge(); Öğün ve Toplam Kalori Hasabı ile sıralama Challenge Listesi dödürüyor
            // En çok tercih edilenleri hangi doğrultuda sıralamak istediğimiz konusunda fikirlere açığım :D
        }
    }
}
