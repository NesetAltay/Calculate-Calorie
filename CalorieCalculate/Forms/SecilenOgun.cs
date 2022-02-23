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
    public partial class SecilenOgun : Form
    {
        private Repast repast;

        public SecilenOgun()
        {
            InitializeComponent();
        }

        public SecilenOgun(Repast repast)
        {
            this.repast = repast;
            lblOgunAdi.Text = repast.RepastName;
        }
    }
}
