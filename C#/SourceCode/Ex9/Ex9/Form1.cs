using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
            for (int i=1; i<=10; i++)
            {
                listBoxAllItem.Items.Add("Item " + i.ToString());
            }
        }

        private void checkedListBoxAllItem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxAllItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxItemChecked.FindStringExact(listBoxAllItem.SelectedItem.ToString()) != -1)
            {
                MessageBox.Show("Bạn đã chọn rồi !", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                listBoxItemChecked.Items.Add(listBoxAllItem.SelectedItem);
            }
        }

        private void listBoxItemChecked_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thông báo", "Bạn muốn xóa mặt hàng đã chọn ?", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                listBoxItemChecked.Items.RemoveAt(listBoxItemChecked.SelectedIndex);
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string msg = "Họ tên: " + textBoxFullName.Text + "\nSĐT: " + textBoxPhone.Text + "\n" + "Bạn đã chọn: ";

            foreach (string i in listBoxItemChecked.Items)
            {
                msg += " \n-"+i;
            }

            msg += "\n Phương thức thanh toán: ";

            if (radioButtonPaySec.Checked)
            {
                msg += "Sec";
            }

            if (radioButtonPayMoney.Checked)
            {
                msg += "Money";
            }

            if (radioButtonPayCredit.Checked)
            {
                msg += "Credit";
            }

            msg += "\n Hình thức liên lạc: ";

            if (checkBoxContactEmail.Checked)
            {
                msg += "Credit ";
            }

            if (checkBoxContactFax.Checked)
            {
                msg += "Fax ";
            }

            if (checkBoxContactPhone.Checked)
            {
                msg += "Phone ";
            }

            MessageBox.Show(msg, "Message", MessageBoxButtons.OK);
        }

        private void buttonOk_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
