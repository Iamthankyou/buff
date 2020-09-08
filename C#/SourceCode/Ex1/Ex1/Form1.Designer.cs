namespace Ex1
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
            this.txMonth = new System.Windows.Forms.TextBox();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.txYear = new System.Windows.Forms.TextBox();
            this.btResult = new System.Windows.Forms.Button();
            this.btAgain = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txMonth
            // 
            this.txMonth.Location = new System.Drawing.Point(187, 47);
            this.txMonth.Name = "txMonth";
            this.txMonth.Size = new System.Drawing.Size(161, 20);
            this.txMonth.TabIndex = 0;
            this.txMonth.TextChanged += new System.EventHandler(this.txMonth_TextChanged);
            this.txMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txMonth_KeyPress);
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(112, 50);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(69, 13);
            this.lbMonth.TabIndex = 1;
            this.lbMonth.Text = "Nhập tháng: ";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(114, 102);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(62, 13);
            this.lbYear.TabIndex = 2;
            this.lbYear.Text = "Nhập năm: ";
            // 
            // txYear
            // 
            this.txYear.AcceptsReturn = true;
            this.txYear.Location = new System.Drawing.Point(187, 99);
            this.txYear.Name = "txYear";
            this.txYear.Size = new System.Drawing.Size(161, 20);
            this.txYear.TabIndex = 3;
            this.txYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txYear.TextChanged += new System.EventHandler(this.txYear_TextChanged);
            this.txYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txYear_KeyPress);
            // 
            // btResult
            // 
            this.btResult.Location = new System.Drawing.Point(37, 180);
            this.btResult.Name = "btResult";
            this.btResult.Size = new System.Drawing.Size(103, 47);
            this.btResult.TabIndex = 4;
            this.btResult.Text = "Kết quả";
            this.btResult.UseVisualStyleBackColor = true;
            this.btResult.Click += new System.EventHandler(this.btResult_Click);
            // 
            // btAgain
            // 
            this.btAgain.Location = new System.Drawing.Point(181, 180);
            this.btAgain.Name = "btAgain";
            this.btAgain.Size = new System.Drawing.Size(103, 47);
            this.btAgain.TabIndex = 5;
            this.btAgain.Text = "Làm lại";
            this.btAgain.UseVisualStyleBackColor = true;
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(334, 180);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(103, 47);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = true;
            // 
            // lbRes
            // 
            this.lbRes.AutoSize = true;
            this.lbRes.Location = new System.Drawing.Point(84, 141);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(0, 13);
            this.lbRes.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(460, 263);
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btAgain);
            this.Controls.Add(this.btResult);
            this.Controls.Add(this.txYear);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.txMonth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txMonth;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox txYear;
        private System.Windows.Forms.Button btResult;
        private System.Windows.Forms.Button btAgain;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbRes;
    }
}

