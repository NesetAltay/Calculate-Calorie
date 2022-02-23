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
        private int user;

        public Raporlar()
        {
            InitializeComponent();
        }

        public Raporlar(int user)
        {
            this.user = user;
        }
    }
}
