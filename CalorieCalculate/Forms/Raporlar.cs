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
            InitializeComponent();
            this.user = user;
        }
        private void Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Form f = default;
            f = new SecilenRapor(btn.Tag.ToString(), user);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
