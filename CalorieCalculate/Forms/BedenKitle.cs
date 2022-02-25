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
    public partial class BedenKitle : Form
    {
        private string v;

        public BedenKitle()
        {
            InitializeComponent();
        }
        public BedenKitle(string v)
        {
            InitializeComponent();
            this.v = v;
            lblSonuc.Text = v;
         
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
