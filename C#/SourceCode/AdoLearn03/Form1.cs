using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoLearn03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tblMonEntities db = new tblMonEntities();

            gridView.DataSource = db.tblmons.ToList();

            gridView.Columns[0].HeaderText = "Mã môn";
            gridView.Columns[1].HeaderText = "Tên môn";

        }
    }
}
