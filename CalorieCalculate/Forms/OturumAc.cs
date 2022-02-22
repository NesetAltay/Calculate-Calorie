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
    public partial class OturumAc : Form
    {
        public OturumAc()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //context = database olacak.
            //result sorgusu bir if içerisine yazılıp nullorempty metodu çağırılır.Eğer resultın bir id si varsa bu girilen emailin dogru oldugunu gösterir, ardından lastResult sorgusu çalışır ve email-password uyusuyor mu bu sorgulanır.
            //var result = from x in context.user where x.Email == txtEmail.KLCText.ToString() select x.Id;
            //var lastResult = from x in context.user where x.Id == result select x.Password;

        }
    }
}
