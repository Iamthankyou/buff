namespace Ex9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonPayCredit = new System.Windows.Forms.RadioButton();
            this.radioButtonPayMoney = new System.Windows.Forms.RadioButton();
            this.radioButtonPaySec = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxContactEmail = new System.Windows.Forms.CheckBox();
            this.checkBoxContactFax = new System.Windows.Forms.CheckBox();
            this.checkBoxContactPhone = new System.Windows.Forms.CheckBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.listBoxAllItem = new System.Windows.Forms.ListBox();
            this.listBoxItemChecked = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Danh sách mặt hàng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Danh sách mặt hàng đã mua:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonPayCredit);
            this.groupBox1.Controls.Add(this.radioButtonPayMoney);
            this.groupBox1.Controls.Add(this.radioButtonPaySec);
            this.groupBox1.Location = new System.Drawing.Point(32, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương thức thanh toán";
            // 
            // radioButtonPayCredit
            // 
            this.radioButtonPayCredit.AutoSize = true;
            this.radioButtonPayCredit.Location = new System.Drawing.Point(29, 77);
            this.radioButtonPayCredit.Name = "radioButtonPayCredit";
            this.radioButtonPayCredit.Size = new System.Drawing.Size(87, 17);
            this.radioButtonPayCredit.TabIndex = 2;
            this.radioButtonPayCredit.TabStop = true;
            this.radioButtonPayCredit.Text = "Thẻ tín dụng";
            this.radioButtonPayCredit.UseVisualStyleBackColor = true;
            // 
            // radioButtonPayMoney
            // 
            this.radioButtonPayMoney.AutoSize = true;
            this.radioButtonPayMoney.Location = new System.Drawing.Point(29, 52);
            this.radioButtonPayMoney.Name = "radioButtonPayMoney";
            this.radioButtonPayMoney.Size = new System.Drawing.Size(66, 17);
            this.radioButtonPayMoney.TabIndex = 1;
            this.radioButtonPayMoney.TabStop = true;
            this.radioButtonPayMoney.Text = "Tiền mặt";
            this.radioButtonPayMoney.UseVisualStyleBackColor = true;
            // 
            // radioButtonPaySec
            // 
            this.radioButtonPaySec.AutoSize = true;
            this.radioButtonPaySec.Location = new System.Drawing.Point(29, 27);
            this.radioButtonPaySec.Name = "radioButtonPaySec";
            this.radioButtonPaySec.Size = new System.Drawing.Size(44, 17);
            this.radioButtonPaySec.TabIndex = 0;
            this.radioButtonPaySec.TabStop = true;
            this.radioButtonPaySec.Text = "Sec";
            this.radioButtonPaySec.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxContactEmail);
            this.groupBox2.Controls.Add(this.checkBoxContactFax);
            this.groupBox2.Controls.Add(this.checkBoxContactPhone);
            this.groupBox2.Location = new System.Drawing.Point(314, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hình thức liên lạc";
            // 
            // checkBoxContactEmail
            // 
            this.checkBoxContactEmail.AutoSize = true;
            this.checkBoxContactEmail.Location = new System.Drawing.Point(24, 77);
            this.checkBoxContactEmail.Name = "checkBoxContactEmail";
            this.checkBoxContactEmail.Size = new System.Drawing.Size(51, 17);
            this.checkBoxContactEmail.TabIndex = 2;
            this.checkBoxContactEmail.Text = "Email";
            this.checkBoxContactEmail.UseVisualStyleBackColor = true;
            // 
            // checkBoxContactFax
            // 
            this.checkBoxContactFax.AutoSize = true;
            this.checkBoxContactFax.Location = new System.Drawing.Point(24, 52);
            this.checkBoxContactFax.Name = "checkBoxContactFax";
            this.checkBoxContactFax.Size = new System.Drawing.Size(43, 17);
            this.checkBoxContactFax.TabIndex = 1;
            this.checkBoxContactFax.Text = "Fax";
            this.checkBoxContactFax.UseVisualStyleBackColor = true;
            // 
            // checkBoxContactPhone
            // 
            this.checkBoxContactPhone.AutoSize = true;
            this.checkBoxContactPhone.Location = new System.Drawing.Point(24, 27);
            this.checkBoxContactPhone.Name = "checkBoxContactPhone";
            this.checkBoxContactPhone.Size = new System.Drawing.Size(89, 17);
            this.checkBoxContactPhone.TabIndex = 0;
            this.checkBoxContactPhone.Text = "Số điện thoại";
            this.checkBoxContactPhone.UseVisualStyleBackColor = true;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(78, 28);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(154, 20);
            this.textBoxFullName.TabIndex = 8;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(354, 28);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(160, 20);
            this.textBoxPhone.TabIndex = 9;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(144, 341);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "Đồng ý";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            this.buttonOk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.buttonOk_KeyPress);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(311, 341);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "Thoát";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // listBoxAllItem
            // 
            this.listBoxAllItem.FormattingEnabled = true;
            this.listBoxAllItem.Location = new System.Drawing.Point(32, 100);
            this.listBoxAllItem.Name = "listBoxAllItem";
            this.listBoxAllItem.Size = new System.Drawing.Size(200, 108);
            this.listBoxAllItem.TabIndex = 12;
            this.listBoxAllItem.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxAllItem_MouseDoubleClick);
            // 
            // listBoxItemChecked
            // 
            this.listBoxItemChecked.FormattingEnabled = true;
            this.listBoxItemChecked.Location = new System.Drawing.Point(314, 100);
            this.listBoxItemChecked.Name = "listBoxItemChecked";
            this.listBoxItemChecked.Size = new System.Drawing.Size(200, 108);
            this.listBoxItemChecked.TabIndex = 13;
            this.listBoxItemChecked.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxItemChecked_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 376);
            this.Controls.Add(this.listBoxItemChecked);
            this.Controls.Add(this.listBoxAllItem);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "y";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPayCredit;
        private System.Windows.Forms.RadioButton radioButtonPayMoney;
        private System.Windows.Forms.RadioButton radioButtonPaySec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxContactEmail;
        private System.Windows.Forms.CheckBox checkBoxContactFax;
        private System.Windows.Forms.CheckBox checkBoxContactPhone;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ListBox listBoxAllItem;
        private System.Windows.Forms.ListBox listBoxItemChecked;
    }
}

