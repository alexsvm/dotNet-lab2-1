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
            Opacity = Convert.ToDouble(numericUpDown1.Value) / 100.0;
        }

        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Opacity = Convert.ToDouble(numericUpDown1.Value) / 100.0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex )
            {
                case 0:
                    FormBorderStyle = FormBorderStyle.Fixed3D;
                    break;
                case 1:
                    FormBorderStyle = FormBorderStyle.FixedDialog;
                    break;
                case 2:
                    FormBorderStyle = FormBorderStyle.FixedSingle;
                    break;
                case 3:
                    FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    break;
                case 4:
                    FormBorderStyle = FormBorderStyle.None;
                    break;
                case 5:
                    FormBorderStyle = FormBorderStyle.Sizable;
                    break;
                case 6:
                    FormBorderStyle = FormBorderStyle.SizableToolWindow;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Width = Convert.ToInt16(numW.Value);
            Height = Convert.ToInt16(numH.Value);
        }
    }
}
