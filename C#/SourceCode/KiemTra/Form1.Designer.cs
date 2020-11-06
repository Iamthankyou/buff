namespace KiemTra
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txMaVatLieu = new System.Windows.Forms.TextBox();
            this.txTenVatLieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txDonViTinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txGiaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txGiaBan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txGhiChu = new System.Windows.Forms.TextBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoQua = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txGhiChu);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.imgBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txSoLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txGiaBan);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txGiaNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txDonViTinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txTenVatLieu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txMaVatLieu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(42, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(793, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin vật liệu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã vật liệu";
            // 
            // txMaVatLieu
            // 
            this.txMaVatLieu.Location = new System.Drawing.Point(120, 32);
            this.txMaVatLieu.Name = "txMaVatLieu";
            this.txMaVatLieu.Size = new System.Drawing.Size(208, 20);
            this.txMaVatLieu.TabIndex = 1;
            // 
            // txTenVatLieu
            // 
            this.txTenVatLieu.Location = new System.Drawing.Point(120, 58);
            this.txTenVatLieu.Name = "txTenVatLieu";
            this.txTenVatLieu.Size = new System.Drawing.Size(208, 20);
            this.txTenVatLieu.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên vật liệu";
            // 
            // txDonViTinh
            // 
            this.txDonViTinh.Location = new System.Drawing.Point(120, 84);
            this.txDonViTinh.Name = "txDonViTinh";
            this.txDonViTinh.Size = new System.Drawing.Size(208, 20);
            this.txDonViTinh.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đơn vị tính";
            // 
            // txGiaNhap
            // 
            this.txGiaNhap.Location = new System.Drawing.Point(120, 110);
            this.txGiaNhap.Name = "txGiaNhap";
            this.txGiaNhap.Size = new System.Drawing.Size(208, 20);
            this.txGiaNhap.TabIndex = 7;
            this.txGiaNhap.TextChanged += new System.EventHandler(this.txGiaNhap_TextChanged);
            this.txGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txGiaNhap_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá nhập";
            // 
            // txSoLuong
            // 
            this.txSoLuong.Location = new System.Drawing.Point(120, 162);
            this.txSoLuong.Name = "txSoLuong";
            this.txSoLuong.Size = new System.Drawing.Size(208, 20);
            this.txSoLuong.TabIndex = 11;
            this.txSoLuong.TextChanged += new System.EventHandler(this.txSoLuong_TextChanged);
            this.txSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSoLuong_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Số lượng";
            // 
            // txGiaBan
            // 
            this.txGiaBan.Location = new System.Drawing.Point(120, 136);
            this.txGiaBan.Name = "txGiaBan";
            this.txGiaBan.Size = new System.Drawing.Size(208, 20);
            this.txGiaBan.TabIndex = 9;
            this.txGiaBan.TextChanged += new System.EventHandler(this.txGiaBan_TextChanged);
            this.txGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txGiaBan_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Giá bán";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ảnh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(597, 23);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(137, 95);
            this.imgBox.TabIndex = 13;
            this.imgBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(503, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ghi chú";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txGhiChu
            // 
            this.txGhiChu.Location = new System.Drawing.Point(544, 131);
            this.txGhiChu.Multiline = true;
            this.txGhiChu.Name = "txGhiChu";
            this.txGhiChu.Size = new System.Drawing.Size(190, 75);
            this.txGhiChu.TabIndex = 15;
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(42, 281);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(793, 118);
            this.gridView.TabIndex = 1;
            this.gridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(162, 420);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 37);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(296, 420);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 37);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(446, 420);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 37);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBoQua
            // 
            this.btnBoQua.Location = new System.Drawing.Point(585, 420);
            this.btnBoQua.Name = "btnBoQua";
            this.btnBoQua.Size = new System.Drawing.Size(75, 37);
            this.btnBoQua.TabIndex = 5;
            this.btnBoQua.Text = "Bỏ qua";
            this.btnBoQua.UseVisualStyleBackColor = true;
            this.btnBoQua.Click += new System.EventHandler(this.btnBoQua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 488);
            this.Controls.Add(this.btnBoQua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txGiaBan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txGiaNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txDonViTinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txTenVatLieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txMaVatLieu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoQua;
    }
}

