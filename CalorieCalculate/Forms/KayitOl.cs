using CalorieCalculate.Crud;
using CalorieCalculate.Extensions;
using CalorieCalculate.Model.Data;
using CalorieCalculate.Model.Entities;
using KLCToolbox.KLCControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCalculate.Forms
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
            txtName.Select();
        }

        private void Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Tag.ToString())
            {
                case "1":
                    DataLoad();
                    this.Close();
                    break;
                case "2":
                    this.Close();
                    break;
            }
        }

        // Database e yeni kullanıcı ekleme
        private void DataLoad()
        {
            List<string> text = new List<string>() { txtName.KLCText, txtLastName.KLCText, txtEmail.KLCText, txtHeight.KLCText, txtPassword.KLCText, txtWeight.KLCText };

            DataCreate create = new DataCreate();

            if (!StringExtension.TestForNullOrEmpty(text) 
                && !StringExtension.IsEquelsEmail(txtEmail.KLCText) 
                && StringExtension.IsValidEmail(txtEmail.KLCText))
            {
                if (txtPassword.KLCText == txtPassword2.KLCText 
                    && StringExtension.IsValidPassword(txtPassword.KLCText))
                {
                    create.CreateUser(txtEmail.KLCText, txtPassword.KLCText);
                    create.CreateUserInformation(txtName.KLCText, txtLastName.KLCText, txtHeight.KLCText, txtWeight.KLCText, dtpBirthdate.Value);
                    OturumAc ac = new OturumAc();
                    ac.txtEmail.KLCText = txtEmail.KLCText;
                    ac.ShowDialog();
                }
                else MessageBox.Show("Şifre alanları eşleşmiyor veya Şifre belirlenen kriterlere uygun değil, Lütfen kontrol edin!", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Lütfen girmiş olduğunuz verileri kontrol edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
