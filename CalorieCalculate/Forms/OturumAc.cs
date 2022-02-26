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
            Remember();
        }
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            bool result = StringExtension.AnyUser(txtEmail.KLCText, txtPassword.KLCText);
            User user = DataRead.GetUser(txtEmail.KLCText, txtPassword.KLCText);
            if (result)
            {
                SaveRemember();
                Interface frm = new Interface(user);
                this.Close();
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

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnGirisYap.PerformClick();
        }
        private void Remember()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remember == true)
                {
                    txtEmail.KLCText = Properties.Settings.Default.UserName;
                    txtPassword.KLCText = Properties.Settings.Default.Password;
                    klcToggleButton1.Checked = true;
                }
                else
                {
                    txtEmail.KLCText = Properties.Settings.Default.UserName;
                }
            }
        }
        private void SaveRemember()
        {
            if (klcToggleButton1.Checked)
            {
                Properties.Settings.Default.UserName = txtEmail.KLCText;
                Properties.Settings.Default.Password = txtPassword.KLCText;
                Properties.Settings.Default.Remember = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remember = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
