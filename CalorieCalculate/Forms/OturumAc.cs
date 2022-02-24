using CalorieCalculate.Crud;
using CalorieCalculate.Extensions;
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
    public partial class OturumAc : Form
    {
        public OturumAc()
        {
            InitializeComponent();
            txtEmail.Select();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            //"altayneset@gmail.com", "12345Neset"
            bool result = StringExtension.AnyUser(txtEmail.KLCText, txtPassword.KLCText);
            User user = DataRead.GetUser(txtEmail.KLCText, txtPassword.KLCText);
                if (result)
                {
                    Interface frm = new Interface(user);
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Girdiğiniz bilgiler eşleşmiyor", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
