namespace AdoLearn01
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txMaMon = new DevExpress.XtraEditors.TextEdit();
            this.txTenMon = new DevExpress.XtraEditors.TextEdit();
            this.txSoTC = new DevExpress.XtraEditors.TextEdit();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txMaMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTenMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSoTC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(67, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã môn";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(67, 114);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Tên môn";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(67, 157);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Số tín chỉ";
            // 
            // txMaMon
            // 
            this.txMaMon.Location = new System.Drawing.Point(180, 66);
            this.txMaMon.Name = "txMaMon";
            this.txMaMon.Size = new System.Drawing.Size(100, 20);
            this.txMaMon.TabIndex = 3;
            // 
            // txTenMon
            // 
            this.txTenMon.Location = new System.Drawing.Point(180, 111);
            this.txTenMon.Name = "txTenMon";
            this.txTenMon.Size = new System.Drawing.Size(100, 20);
            this.txTenMon.TabIndex = 4;
            // 
            // txSoTC
            // 
            this.txSoTC.Location = new System.Drawing.Point(180, 150);
            this.txSoTC.Name = "txSoTC";
            this.txSoTC.Size = new System.Drawing.Size(100, 20);
            this.txSoTC.TabIndex = 5;
            this.txSoTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txSoTC_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(129, 201);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Thêm";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 277);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txSoTC);
            this.Controls.Add(this.txTenMon);
            this.Controls.Add(this.txMaMon);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.txMaMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txTenMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txSoTC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txMaMon;
        private DevExpress.XtraEditors.TextEdit txTenMon;
        private DevExpress.XtraEditors.TextEdit txSoTC;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
    }
}

