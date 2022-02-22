﻿using System;
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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();

        }

        private void Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            int a = int.Parse(lbl.Tag.ToString());
            Form f = default;
            switch (a)
            {
                case 1:
                    f = new KayitOl();
                    break;
                case 2:
                    f = new OturumAc();
                    break;
            }
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
