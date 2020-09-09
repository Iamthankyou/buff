using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex5
{
    public partial class Form1 : Form
    {
        private string msg = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void listBoxNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBoxNumber.MultiColumn = true;
            listBoxNumber.ColumnWidth = listBoxNumber.Width/ 4;
            listBoxNumber.SelectionMode = SelectionMode.MultiSimple;

            for (int i=1; i<=100; i++)
            {
                listBoxNumber.Items.Add("Item " + i.ToString());
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (string i in listBoxNumber.SelectedItems)
            {
                msg += i+ " ";
            }

            MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
