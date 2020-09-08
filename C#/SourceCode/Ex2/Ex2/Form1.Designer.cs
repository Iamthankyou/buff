namespace Ex2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txMonth = new System.Windows.Forms.TextBox();
            this.txYear = new System.Windows.Forms.TextBox();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.btRes = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.lbRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txMonth
            // 
            this.txMonth.Location = new System.Drawing.Point(121, 70);
            this.txMonth.Name = "txMonth";
            this.txMonth.Size = new System.Drawing.Size(199, 23);
            this.txMonth.TabIndex = 0;
            this.txMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txMonth_KeyPress);
            // 
            // txYear
            // 
            this.txYear.Location = new System.Drawing.Point(121, 125);
            this.txYear.Name = "txYear";
            this.txYear.Size = new System.Drawing.Size(199, 23);
            this.txYear.TabIndex = 1;
            this.txYear.TextChanged += new System.EventHandler(this.txYear_TextChanged);
            this.txYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txYear_KeyPress);
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(38, 73);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(73, 15);
            this.lbMonth.TabIndex = 1;
            this.lbMonth.Text = "Nhập tháng:";
            this.lbMonth.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(38, 128);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(66, 15);
            this.lbYear.TabIndex = 1;
            this.lbYear.Text = "Nhập năm:";
            this.lbYear.Click += new System.EventHandler(this.label1_Click);
            // 
            // btRes
            // 
            this.btRes.Location = new System.Drawing.Point(29, 199);
            this.btRes.Name = "btRes";
            this.btRes.Size = new System.Drawing.Size(75, 23);
            this.btRes.TabIndex = 2;
            this.btRes.Text = "Kết quả";
            this.btRes.UseVisualStyleBackColor = true;
            this.btRes.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt3
            // 
            this.bt3.Location = new System.Drawing.Point(276, 199);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 23);
            this.bt3.TabIndex = 4;
            this.bt3.Text = "Thoát";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.btExit);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(153, 199);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 23);
            this.bt2.TabIndex = 3;
            this.bt2.Text = "Làm lại";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.btAgain);
            // 
            // lbRes
            // 
            this.lbRes.AutoSize = true;
            this.lbRes.Location = new System.Drawing.Point(66, 164);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(0, 15);
            this.lbRes.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 234);
            this.Controls.Add(this.lbRes);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.btRes);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.txYear);
            this.Controls.Add(this.txMonth);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txMonth;
        private System.Windows.Forms.TextBox txYear;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Button btRes;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Label lbRes;
    }
}

