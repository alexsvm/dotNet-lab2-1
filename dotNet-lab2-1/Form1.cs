using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNet_lab2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = hScrollBar1.Value.ToString();
            Opacity = hScrollBar1.Value / 100;
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = hScrollBar1.Value.ToString();
            Opacity = hScrollBar1.Value / 100;
        }
    }
}
