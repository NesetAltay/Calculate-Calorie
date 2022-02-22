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
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = context.Users.Any(x => x.Email == txtEmail.KLCText && x.Password == txtPassword.KLCText);
                if (result)
                {
                    Form frm = new Interface();
                    frm.ShowDialog();
                }
                else
                    MessageBox.Show("Girdiğiniz bilgiler eşleşmiyor", "Uyarı", MessageBoxButtons.OK,MessageBoxIcon.Error );
            }
            

        }
    }
}
