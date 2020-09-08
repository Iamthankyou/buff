using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txMonth_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btResult_Click(object sender, EventArgs e)
        {

        }

        private void txMonth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar<'1' || e.KeyChar > '9')
            {
                MessageBox.Show("Not Valid");
                e.Handled = true;
            }
        }

        private void txYear_TextChanged(object sender, EventArgs e)
        {
        }

        private void txYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                MessageBox.Show("Not Valid");
                e.Handled = true;
            }
        }
    }
}
