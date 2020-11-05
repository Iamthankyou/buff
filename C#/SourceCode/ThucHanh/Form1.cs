using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userName = "";
        }

        public static string userName;

        private void button1_Click(object sender, EventArgs e)
        {
            BanHangEntities1 db = new BanHangEntities1();
            var user = db.tblUsers.Find(txUser.Text);

            if (user != null && user.passWord == Encryption.Crypt(txPass.Text))
            {
                userName = user.userName;
            }
            else
            {
                MessageBox.Show("Login fail");
            }
        }
    }
}
