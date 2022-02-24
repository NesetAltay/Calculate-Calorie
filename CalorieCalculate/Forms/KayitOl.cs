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

            if (StringExtension.TestForNullOrEmpty(text))
            { MessageBox.Show("Lütfen bilgilerini tam girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }

            if (StringExtension.IsEquelsEmail(txtEmail.KLCText))
            { MessageBox.Show("Farklı bir kullanıcı adı seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (!StringExtension.IsValidEmail(txtEmail.KLCText))
            { MessageBox.Show("Geçerli bir mail adresi girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (!StringExtension.IsValidPassword(txtPassword.KLCText))
            { MessageBox.Show("Şifreniz 8 karakter uzunluğunda olmalı ve en az bir sayı, bir büyük harf ve bir küçük harf içermelidir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (txtPassword.KLCText != txtPassword2.KLCText)
            { MessageBox.Show("Şifrenizi kontrol edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return; }
            else
            {
                DataCreate.Create(txtEmail.KLCText, txtPassword.KLCText);
                DataCreate.Create(txtName.KLCText, txtLastName.KLCText, txtHeight.KLCText, txtWeight.KLCText, dtpBirthdate.Value);
                OturumAc ac = new OturumAc();
                ac.txtEmail.KLCText = txtEmail.KLCText;
                ac.ShowDialog();
                this.Close();
            }
        }
    }
}
