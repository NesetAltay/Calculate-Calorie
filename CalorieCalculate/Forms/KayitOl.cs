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
            //using (DatabaseContext db = new DatabaseContext())
            //{
            //    try
            //    {
            //        UserInformation information;
            //        User user;
            //        Create(out information, out user);
            //        CreateControl(db, information, user);
            //    }
            //    catch (Exception)
            //    {
            //        MessageBox.Show("Verilerinizi kontrol edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            // Bir sınıf yapısı oluşturuldu ancak metotlar null değerlerde hataya düşmüyor hocaya sorulacak, klasör adı Crud oluşturulan sınıf DataCreate

            List<string> text = new List<string>() { txtName.KLCText, txtLastName.KLCText, txtEmail.KLCText, txtHeight.KLCText, txtPassword.KLCText, txtWeight.KLCText };

            DataCreate create = new DataCreate();
           

            if (!StringExtension.TestForNullOrEmpty(text) && !StringExtension.IsStokEmail(txtEmail.KLCText) && StringExtension.IsValidEmail(txtEmail.KLCText))
            {
                if (txtPassword.KLCText == txtPassword2.KLCText && StringExtension.IsValidPassword(txtPassword.KLCText))
                {

                    create.CreateUser(txtEmail.KLCText, txtPassword.KLCText);
                    create.CreateUserInformation(txtName.KLCText, txtLastName.KLCText, txtHeight.KLCText, txtWeight.KLCText, dtpBirthdate.Value); 
                }
                else MessageBox.Show("Şifre alanları eşleşmiyor veya Şifre belirlenen kriterlere uygun değil, Lütfen kontrol edin!", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Lütfen girmiş olduğunuz verileri kontrol edin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // Yeni kullanıcı oluşturma
        private void Create(out UserInformation information, out User user)
        {
            user = new User()
            {
                Email = txtEmail.KLCText,
                Password = txtPassword.KLCText
            };
            information = new UserInformation()
            {
                FirstName = txtName.KLCText,
                LastName = txtLastName.KLCText,
                BirthDate = (DateTime)dtpBirthdate.Value,
                Height = decimal.Parse(txtHeight.KLCText),
                Weight = decimal.Parse(txtWeight.KLCText)
            };
        }
        // Oluşturulan kullanıcıların bilgilerinin kontrolu
        private void CreateControl(DatabaseContext db, UserInformation information, User user)
        {
            bool result = db.Users.Any(x => x.Email.Equals(txtEmail.KLCText));
            if (txtPassword.KLCText != txtPassword2.KLCText || !txtEmail.KLCText.IsValidEmail() || result)
            {
                MessageBox.Show("Email veya parola hatalı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                db.Users.Add(user);
                db.SaveChanges();
                information.Id = user.Id;
                db.UserInformations.Add(information);
                db.SaveChanges();
                Form f = new OturumAc();
                f.ShowDialog();
            }
        }

       

    }
}
