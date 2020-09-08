using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Boolean isLeafYear(int n)
        {
            return n % 4 == 0 || n % 400 == 0 && n % 100 != 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt16(txYear.Text);
            int month = Convert.ToInt16(txMonth.Text);
            int[] dayOfMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month == 2 && isLeafYear(year) == true)
            {
                lbRes.Text = "Tháng "+ month.ToString() + " năm "+ year.ToString()+ " có: " + 29.ToString() + " ngày";
            }
            else
            {
                lbRes.Text = "Tháng " + month.ToString() + " năm " + year.ToString() + " có: " + dayOfMonth[month].ToString() + " ngày";
            }
        }

        private void txMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <'1' || e.KeyChar > '9')
            {
                if (e.KeyChar == 13)
                {
                    if (Convert.ToInt16(txMonth.Text) <0 || Convert.ToInt16(txMonth.Text) >12)
                    {
                        MessageBox.Show("Range 1-12");
                        e.Handled = true;
                    }
                    else
                    {
                        SendKeys.Send("{TAB}");
                    }
                }
                else if (e.KeyChar != '\b')
                {
                    MessageBox.Show("Not Valid");
                    e.Handled = true;
                }
            }
        }

        private void txYear_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                if (e.KeyChar == 13)
                {
                    if (Convert.ToInt16(txMonth.Text) < 0 || Convert.ToInt16(txMonth.Text) > 12)
                    {
                        MessageBox.Show("Range 1-12");
                        e.Handled = true;
                    }
                    else
                    {
                        SendKeys.Send("{TAB}");
                    }
                }
                else if (e.KeyChar != '\b')
                {
                    MessageBox.Show("Not Valid");
                    e.Handled = true;
                }
            }
        }

        private void btExit(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAgain(object sender, EventArgs e)
        {
            txMonth.Text = "";
            txYear.Text = "";

            txMonth.BringToFront();
        }
    }
}
