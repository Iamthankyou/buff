using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoLearn02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tblMonEntities1 database = new tblMonEntities1();
            database.tblmons.Add(new tblmon() { MaMon = textEdit1.Text, SoTC = Convert.ToInt32(textEdit3.Text), TenMon = textEdit2.Text}) ;
            database.SaveChanges();
        }

        private BindingList<tblmon> _tblmon;

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            tblMonEntities1 database = new tblMonEntities1();

            // listBox1.DataSource = database.tblmons.Select(m => m.TenMon);            
            listBox1.DataSource = database.tblmons.ToList();
            listBox1.DisplayMember = "TenMon";
            listBox1.ValueMember = "MaMon";
        }
    }
}
