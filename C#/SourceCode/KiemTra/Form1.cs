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

namespace KiemTra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string url;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            txMaVatLieu.Enabled = false;

          

            updateGridView();

            url = gridView.CurrentRow.Cells[6].Value.ToString();

            txMaVatLieu.Text = gridView.CurrentRow.Cells[0].Value.ToString();
            txTenVatLieu.Text = gridView.CurrentRow.Cells[1].Value.ToString();
            txDonViTinh.Text = gridView.CurrentRow.Cells[2].Value.ToString();
            txGiaNhap.Text = gridView.CurrentRow.Cells[3].Value.ToString();
            txGiaBan.Text = gridView.CurrentRow.Cells[4].Value.ToString();
            txSoLuong.Text = gridView.CurrentRow.Cells[5].Value.ToString();

            txGhiChu.Text = gridView.CurrentRow.Cells[7].Value.ToString();

            imgBox.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().ToString() + gridView.CurrentRow.Cells[6].Value.ToString());
            imgBox.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void updateGridView()
        {
            DuLieuEntities db = new DuLieuEntities();
            gridView.DataSource = db.VatLieux.ToList();

            gridView.Columns[0].HeaderText = "Mã vật liệu";
            gridView.Columns[1].HeaderText = "Tên vật liệu";
            gridView.Columns[2].HeaderText = "Đơn vị tính";
            gridView.Columns[3].HeaderText = "Giá nhập";
            gridView.Columns[4].HeaderText = "Giá bán";
            gridView.Columns[6].HeaderText = "File ảnh";
            gridView.Columns[7].HeaderText = "Ghi chú";
            gridView.Columns[5].HeaderText = "Số lượng";
        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            txMaVatLieu.Enabled = true;

            txMaVatLieu.Text = gridView.CurrentRow.Cells[0].Value.ToString();
            txTenVatLieu.Text = gridView.CurrentRow.Cells[1].Value.ToString();
            txDonViTinh.Text = gridView.CurrentRow.Cells[2].Value.ToString();
            txGiaNhap.Text = gridView.CurrentRow.Cells[3].Value.ToString();
            txGiaBan.Text = gridView.CurrentRow.Cells[4].Value.ToString();
            txSoLuong.Text = gridView.CurrentRow.Cells[5].Value.ToString();

            txGhiChu.Text = gridView.CurrentRow.Cells[7].Value.ToString();

            
            imgBox.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory().ToString() + gridView.CurrentRow.Cells[6].Value.ToString());
            imgBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            txMaVatLieu.Text = "";
            txTenVatLieu.Text = "";
            txDonViTinh.Text = "";
            txGiaNhap.Text = "";
            txGiaBan.Text = "";
            txSoLuong.Text = "";

            txGhiChu.Text = "";

            imgBox.Image = null;

            if (MessageBox.Show("Yes or no", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DuLieuEntities db = new DuLieuEntities();

            if (txMaVatLieu.Text != "" && txTenVatLieu.Text!="" && txDonViTinh.Text!="" && txGiaNhap.Text!="" && txSoLuong.Text != "")
            {
                if (db.VatLieux.Find(txMaVatLieu.Text) == null)
                {
                    db.VatLieux.Add(new VatLieu()
                    {
                        MAVL = txMaVatLieu.Text,
                        TenVatLieu = txTenVatLieu.Text,
                        DonViTinh = txTenVatLieu.Text,
                        GiaNhap = Convert.ToDouble(txGiaNhap.Text),
                        GiaBan = Convert.ToDouble(txGiaBan.Text),
                        SoLuong = Convert.ToInt32(txSoLuong.Text),
                        GhiChu = txGhiChu.Text,
                        Anh = url

                    }) ;

                    db.SaveChanges();

                    updateGridView();
                }
                else
                {
                    MessageBox.Show("Đã tồn tại mã này");
                }
            }
            else
            {
                MessageBox.Show("Mã vật liệu, Tên Vật liệu, Đơn vị tính, Giá nhập, Số lượng không được rỗng");
            }
        }

        private void txGiaNhap_TextChanged(object sender, EventArgs e)
        {
        }

        private void txGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
            
            if (e.Handled)
            {
                MessageBox.Show("Chỉ nhập số");
            }
        }

        private void txGiaBan_TextChanged(object sender, EventArgs e)
        {
        }

        private void txSoLuong_TextChanged(object sender, EventArgs e)
        {
        }

        private void txGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;

            if (e.Handled)
            {
                MessageBox.Show("Chỉ nhập số");
            }

        }

        private void txSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;

            if (e.Handled)
            {
                MessageBox.Show("Chỉ nhập số");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DuLieuEntities db = new DuLieuEntities();

            if (txMaVatLieu.Text != "" && txTenVatLieu.Text != "" && txDonViTinh.Text != "" && txGiaNhap.Text != "" && txSoLuong.Text != "")
            {
                    db.VatLieux.AddOrUpdate(new VatLieu()
                    {
                        MAVL = txMaVatLieu.Text,
                        TenVatLieu = txTenVatLieu.Text,
                        DonViTinh = txTenVatLieu.Text,
                        GiaNhap = Convert.ToDouble(txGiaNhap.Text),
                        GiaBan = Convert.ToDouble(txGiaBan.Text),
                        SoLuong = Convert.ToInt32(txSoLuong.Text),
                        GhiChu = txGhiChu.Text,
                        Anh = url

                    });

                    db.SaveChanges();

                    updateGridView();

                txMaVatLieu.Text = "";
                txTenVatLieu.Text = "";
                txDonViTinh.Text = "";
                txGiaNhap.Text = "";
                txGiaBan.Text = "";
                txSoLuong.Text = "";

                txGhiChu.Text = "";

                imgBox.Image = null;

            }
            else
            {
                MessageBox.Show("Mã vật liệu, Tên Vật liệu, Đơn vị tính, Giá nhập, Số lượng không được rỗng");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yes or no", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                DuLieuEntities db = new DuLieuEntities();

                VatLieu del = db.VatLieux.Where(a => a.MAVL == txMaVatLieu.Text).Single<VatLieu>();

                if (del != null)
                {
                    db.VatLieux.Remove(del);
                    db.SaveChanges();
                    updateGridView();
                }

            }

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
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
    