using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex23
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void phépTrừuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phépCộng1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd frm = new frmAdd();
            frm.showDialog();
        }
    }
}
