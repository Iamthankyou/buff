using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (btnAdd.Checked && txA.TextLength!=0 && txB.TextLength!=0)
            {
                double a = Convert.ToDouble(txA.Text);
                double b = Convert.ToDouble(txB.Text);

                txC.Text = (a + b).ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar == 13)
                {
                    SendKeys.Send("{TAB}");
                }
                else if (e.KeyChar != '\b')
                {
                    MessageBox.Show("Only Number");
                    e.Handled = true;
                }
            }
            
        }

        private void txB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar == 13)
                {
                    SendKeys.Send("{TAB}");
                }
                else if (e.KeyChar != '\b')
                {
                    MessageBox.Show("Only Number");
                    e.Handled = true;
                }
            }
        }

        private void btnSub_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSub.Checked && txA.TextLength != 0 && txB.TextLength != 0)
            {
                double a = Convert.ToDouble(txA.Text);
                double b = Convert.ToDouble(txB.Text);

                txC.Text = (a - b).ToString();
            }
        }

        private void btnProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (btnProduct.Checked && txA.TextLength != 0 && txB.TextLength != 0)
            {
                double a = Convert.ToDouble(txA.Text);
                double b = Convert.ToDouble(txB.Text);

                txC.Text = (a * b).ToString();
            }
        }

        private void btnDivide_CheckedChanged(object sender, EventArgs e)
        {
            if (btnDivide.Checked && txA.TextLength != 0 && txB.TextLength != 0)
            {
                double a = Convert.ToDouble(txA.Text);
                double b = Convert.ToDouble(txB.Text);

                txC.Text = (a + b).ToString();
            }
        }

        private void checkBoxMax_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMax.Checked && txA.TextLength != 0 && txB.TextLength != 0)
            {
                lbMax.Text = Math.Max(Convert.ToDouble(txA.Text), Convert.ToDouble(txB.Text)).ToString();
            }
            else
            {
                lbMax.Text = "";
            }
        }

        private void checkBoxMin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMax.Checked && txA.TextLength != 0 && txB.TextLength != 0)
            {
                lbMin.Text = Math.Min(Convert.ToDouble(txA.Text), Convert.ToDouble(txB.Text)).ToString();
            }
            else
            {
                lbMin.Text = "";
            }
        }
    }
}
