namespace Ex3
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
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.txC = new System.Windows.Forms.TextBox();
            this.txB = new System.Windows.Forms.TextBox();
            this.txA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCompare = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.RadioButton();
            this.btnSub = new System.Windows.Forms.RadioButton();
            this.btnProduct = new System.Windows.Forms.RadioButton();
            this.btnDivide = new System.Windows.Forms.RadioButton();
            this.checkBoxMax = new System.Windows.Forms.CheckBox();
            this.checkBoxMin = new System.Windows.Forms.CheckBox();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.groupMain.SuspendLayout();
            this.boxCompare.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMain
            // 
            this.groupMain.Controls.Add(this.txC);
            this.groupMain.Controls.Add(this.txB);
            this.groupMain.Controls.Add(this.txA);
            this.groupMain.Controls.Add(this.label3);
            this.groupMain.Controls.Add(this.label2);
            this.groupMain.Controls.Add(this.label1);
            this.groupMain.Location = new System.Drawing.Point(138, 27);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(229, 137);
            this.groupMain.TabIndex = 0;
            this.groupMain.TabStop = false;
            // 
            // txC
            // 
            this.txC.Location = new System.Drawing.Point(98, 86);
            this.txC.Name = "txC";
            this.txC.ReadOnly = true;
            this.txC.Size = new System.Drawing.Size(100, 20);
            this.txC.TabIndex = 5;
            // 
            // txB
            // 
            this.txB.Location = new System.Drawing.Point(98, 56);
            this.txB.Name = "txB";
            this.txB.Size = new System.Drawing.Size(100, 20);
            this.txB.TabIndex = 4;
            this.txB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txB_KeyPress);
            // 
            // txA
            // 
            this.txA.Location = new System.Drawing.Point(98, 26);
            this.txA.Name = "txA";
            this.txA.Size = new System.Drawing.Size(100, 20);
            this.txA.TabIndex = 3;
            this.txA.TextChanged += new System.EventHandler(this.txA_TextChanged);
            this.txA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txA_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập b=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập a=";
            // 
            // boxCompare
            // 
            this.boxCompare.Controls.Add(this.lbMin);
            this.boxCompare.Controls.Add(this.lbMax);
            this.boxCompare.Controls.Add(this.checkBoxMin);
            this.boxCompare.Controls.Add(this.checkBoxMax);
            this.boxCompare.Location = new System.Drawing.Point(309, 186);
            this.boxCompare.Name = "boxCompare";
            this.boxCompare.Size = new System.Drawing.Size(200, 112);
            this.boxCompare.TabIndex = 2;
            this.boxCompare.TabStop = false;
            this.boxCompare.Text = "So sánh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDivide);
            this.groupBox1.Controls.Add(this.btnProduct);
            this.groupBox1.Controls.Add(this.btnSub);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(33, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(44, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 17);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.TabStop = true;
            this.btnAdd.Text = "Cộng";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnSub
            // 
            this.btnSub.AutoSize = true;
            this.btnSub.Location = new System.Drawing.Point(44, 39);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(41, 17);
            this.btnSub.TabIndex = 1;
            this.btnSub.TabStop = true;
            this.btnSub.Text = "Trừ";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.CheckedChanged += new System.EventHandler(this.btnSub_CheckedChanged);
            // 
            // btnProduct
            // 
            this.btnProduct.AutoSize = true;
            this.btnProduct.Location = new System.Drawing.Point(44, 62);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(51, 17);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.TabStop = true;
            this.btnProduct.Text = "Nhân";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.CheckedChanged += new System.EventHandler(this.btnProduct_CheckedChanged);
            // 
            // btnDivide
            // 
            this.btnDivide.AutoSize = true;
            this.btnDivide.Location = new System.Drawing.Point(44, 83);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(46, 17);
            this.btnDivide.TabIndex = 3;
            this.btnDivide.TabStop = true;
            this.btnDivide.Text = "Chia";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.CheckedChanged += new System.EventHandler(this.btnDivide_CheckedChanged);
            // 
            // checkBoxMax
            // 
            this.checkBoxMax.AutoSize = true;
            this.checkBoxMax.Location = new System.Drawing.Point(41, 30);
            this.checkBoxMax.Name = "checkBoxMax";
            this.checkBoxMax.Size = new System.Drawing.Size(74, 17);
            this.checkBoxMax.TabIndex = 0;
            this.checkBoxMax.Text = "Lớn nhất: ";
            this.checkBoxMax.UseVisualStyleBackColor = true;
            this.checkBoxMax.CheckedChanged += new System.EventHandler(this.checkBoxMax_CheckedChanged);
            // 
            // checkBoxMin
            // 
            this.checkBoxMin.AutoSize = true;
            this.checkBoxMin.Location = new System.Drawing.Point(41, 72);
            this.checkBoxMin.Name = "checkBoxMin";
            this.checkBoxMin.Size = new System.Drawing.Size(76, 17);
            this.checkBoxMin.TabIndex = 1;
            this.checkBoxMin.Text = "Nhỏ nhất: ";
            this.checkBoxMin.UseVisualStyleBackColor = true;
            this.checkBoxMin.CheckedChanged += new System.EventHandler(this.checkBoxMin_CheckedChanged);
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(121, 30);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(0, 13);
            this.lbMax.TabIndex = 2;
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(133, 72);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(0, 13);
            this.lbMin.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(532, 310);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.boxCompare);
            this.Controls.Add(this.groupMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupMain.ResumeLayout(false);
            this.groupMain.PerformLayout();
            this.boxCompare.ResumeLayout(false);
            this.boxCompare.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMain;
        private System.Windows.Forms.TextBox txC;
        private System.Windows.Forms.TextBox txB;
        private System.Windows.Forms.TextBox txA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox boxCompare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnSub;
        private System.Windows.Forms.RadioButton btnAdd;
        private System.Windows.Forms.RadioButton btnDivide;
        private System.Windows.Forms.RadioButton btnProduct;
        private System.Windows.Forms.CheckBox checkBoxMin;
        private System.Windows.Forms.CheckBox checkBoxMax;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbMax;
    }
}

