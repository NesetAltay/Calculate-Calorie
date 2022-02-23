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
    public partial class OturumAc : Form
    {
        public OturumAc()
        {
            InitializeComponent();
            txtEmail.Select();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                //var result = context.Users.Any(x => x.Email == txtEmail.KLCText && x.Password == txtPassword.KLCText);
                //var user = context.Users.Where(x => x.Email.Equals(txtEmail.KLCText) && x.Password.Equals(txtPassword.KLCText))
                //    .Select(x => x.Id).FirstOrDefault();
                var user = context.Users.Where(x => x.Email.Equals("altayneset@gmail.com") && x.Password.Equals("12345Neset"))
                    .Select(x => x.Id).FirstOrDefault();
                if (user != null)
                {
                    Interface frm = new Interface(user);
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Girdiğiniz bilgiler eşleşmiyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = default;
            if (f is null)
            {
                f = new KayitOl();
                this.Close();
                f.ShowDialog();
            }
        }
    }
}
