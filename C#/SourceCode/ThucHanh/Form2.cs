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
    public partial class Form2 : Form
    {
        private string url;

        public Form2()
        {
            InitializeComponent();
        }

        private void lbWelcome_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = Form1.userName;
            updateGridView();
        }

        private void updateGridView()
        {
            BanHangEntities2 db = new BanHangEntities2();

            gridView.DataSource = db.tblHangs.ToList();
            gridView.Columns[0].HeaderText = "Mã hàng";
            gridView.Columns[1].HeaderText = "Tên hàng";
            gridView.Columns[2].HeaderText = "Chất liệu";
            gridView.Columns[3].HeaderText = "Số lượng";
            gridView.Columns[4].HeaderText = "Đơn giá nhập";
            gridView.Columns[5].HeaderText = "Đơn giá bán";
            gridView.Columns[6].HeaderText = "URL";
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txMaHang.Text = gridView.CurrentRow.Cells[0].Value.ToString();
            txTenHang.Text = gridView.CurrentRow.Cells[1].Value.ToString();
            txChatLieu.Text = gridView.CurrentRow.Cells[2].Value.ToString();
            txSoLuong.Text = gridView.CurrentRow.Cells[3].Value.ToString();
            txDonGiaNhap.Text = gridView.CurrentRow.Cells[4].Value.ToString();
            txDonGiaBan.Text = gridView.CurrentRow.Cells[5].Value.ToString();
            url = gridView.CurrentRow.Cells[6].Value.ToString();

            MessageBox.Show(System.IO.Directory.GetCurrentDirectory().ToString() + gridView.CurrentRow.Cells[6].Value.ToString());
            imgBox.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().ToString() + gridView.CurrentRow.Cells[6].Value.ToString());
            imgBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txMaHang.Text!="" && txTenHang.Text!="" && txChatLieu.Text!="" && txDonGiaBan.Text!="" && txDonGiaNhap.Text!= "")
            {
                BanHangEntities2 db = new BanHangEntities2();

                db.tblHangs.Add(new tblHang() { MaHang = txMaHang.Text, TenHang = txTenHang.Text,SoLuong = Convert.ToInt32(txSoLuong.Text), DonGiaBan = Convert.ToDouble(txDonGiaBan.Text), DonGiaNhap = Convert.ToDouble(txDonGiaNhap.Text), ChatLieu = txChatLieu.Text, URL = url});
                db.SaveChanges();

                updateGridView();
            }
            else
            {
                MessageBox.Show("Fill all textbox");
            }
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            openFileDialog.Title = "Chọn ảnh để hiển thị";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                url = openFileDialog.FileName;
                imgBox.Image = Image.FromFile(openFileDialog.FileName);
            }
            else
            {
                MessageBox.Show("Are you ? ", "Open Dialog", MessageBoxButtons.OK);
            }
        }
    }
}
