using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace AdoLearn01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txSoTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar!=8;
            
            if (e.Handled)
            {
                MessageBox.Show("Only number");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            /*
            string strConnect = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source=ADMIN;Initial Catalog = tblMon; Integrated Security = SSPI;User ID = sa; Password = duyduy";
            OleDbConnection connection = new OleDbConnection(strConnect);

            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
            
            String query = "INSERT INTO tbl(MaMon,TenMon,SoTC) VALUES('" + txMaMon.Text + "','" + txTenMon.Text + "'," + txSoTC + ")";

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = query;
            command.ExecuteNonQuery();
    
            if (connection.State!= ConnectionState.Closed)
            {
                connection.Close();
            }
            
            connection.Dispose();
            command.Dispose();
            */

            tblMonEntities1 database = new tblMonEntities1();
        }
    }
}
