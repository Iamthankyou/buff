using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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

        private void updateGridView()
        {

            tblMonEntities db = new tblMonEntities();

            gridView.DataSource = db.tblmons.ToList();

            gridView.Columns[0].HeaderText = "Mã môn";
            gridView.Columns[1].HeaderText = "Tên môn";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnDelete.Enabled = false;
            updateGridView();
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txMaMonHoc.Text = gridView.CurrentRow.Cells[0].Value.ToString();
            txMonHoc.Text = gridView.CurrentRow.Cells[1].Value.ToString();
            txTinChi.Text = gridView.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txMaMonHoc.Text != "" && txMonHoc.Text != "" && txTinChi.Text != "")
            {
                tblMonEntities db = new tblMonEntities();
                if (db.tblmons.Find(txMaMonHoc.Text) == null)
                {
                    db.tblmons.Add(new tblmon() { MaMon = txMaMonHoc.Text, TenMon = txMonHoc.Text, SoTC = Convert.ToInt32(txTinChi.Text) });
                    db.SaveChanges();

                    updateGridView();
                }
                else
                {
                    MessageBox.Show("Primary Key is exist");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txMaMonHoc.Text != "" && txMonHoc.Text != "" && txTinChi.Text != "")
            {
                tblMonEntities db = new tblMonEntities();

                db.tblmons.AddOrUpdate(new tblmon() { MaMon = txMaMonHoc.Text, TenMon = txMonHoc.Text, SoTC = Convert.ToInt32(txTinChi.Text) });
                db.SaveChanges();

                updateGridView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yes or no", "Message",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                tblMonEntities db = new tblMonEntities();

                tblmon del = db.tblmons.Where(a => a.MaMon == txMaMonHoc.Text).Single<tblmon>();

                if (del != null)
                {
                    db.tblmons.Remove(del);
                    db.SaveChanges();
                    updateGridView();
                }

            }
        }
    }
}
