using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txName.TextLength != 0)
            {
                listEnglish.Items.Add(txName.Text);
                txName.Text = "";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            listEnglish.Items.RemoveAt(listEnglish.SelectedIndex);
        }

        private void btnDelete_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void listEnglish_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int pos = listEnglish.FindStringExact(txName.Text);

            if (pos != -1)
            {
                listEnglish.SetSelected(pos,true);
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        private void txName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 && txName.TextLength !=0) {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}