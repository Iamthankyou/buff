using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBoxFood.MultiColumn = true;
            checkedListBoxFood.ColumnWidth = checkedListBoxFood.Width / 2;

            for (int i=1; i<=20; i++)
            {
                checkedListBoxFood.Items.Add("Number " + i.ToString());
            }
        }

        private void checkedListBoxFood_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                MessageBox.Show("Add " + checkedListBoxFood.SelectedItem, "Message", MessageBoxButtons.OK);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string listCheck = "";

            foreach (string i in checkedListBoxFood.CheckedItems)
            {
                listCheck += i + " ";
            }

            MessageBox.Show(listCheck, "Message", MessageBoxButtons.OK);
        }
    }
}
