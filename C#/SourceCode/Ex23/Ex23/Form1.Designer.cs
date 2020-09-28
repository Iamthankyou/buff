namespace Ex23
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.phépCộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phépCộng1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phépCộng2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phépTrừuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trắcNghiệmHìnhHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toánĐốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soSánhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phépCộngToolStripMenuItem,
            this.phépTrừuToolStripMenuItem,
            this.trắcNghiệmHìnhHọcToolStripMenuItem,
            this.toánĐốToolStripMenuItem,
            this.soSánhToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(609, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // phépCộngToolStripMenuItem
            // 
            this.phépCộngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phépCộng1ToolStripMenuItem,
            this.phépCộng2ToolStripMenuItem});
            this.phépCộngToolStripMenuItem.Name = "phépCộngToolStripMenuItem";
            this.phépCộngToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.phépCộngToolStripMenuItem.Text = "Phép cộng";
            // 
            // phépCộng1ToolStripMenuItem
            // 
            this.phépCộng1ToolStripMenuItem.Name = "phépCộng1ToolStripMenuItem";
            this.phépCộng1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phépCộng1ToolStripMenuItem.Text = "Phép cộng 1";
            this.phépCộng1ToolStripMenuItem.Click += new System.EventHandler(this.phépCộng1ToolStripMenuItem_Click);
            // 
            // phépCộng2ToolStripMenuItem
            // 
            this.phépCộng2ToolStripMenuItem.Name = "phépCộng2ToolStripMenuItem";
            this.phépCộng2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.phépCộng2ToolStripMenuItem.Text = "Phép cộng 2";
            // 
            // phépTrừuToolStripMenuItem
            // 
            this.phépTrừuToolStripMenuItem.Name = "phépTrừuToolStripMenuItem";
            this.phépTrừuToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.phépTrừuToolStripMenuItem.Text = "Phép trừ";
            this.phépTrừuToolStripMenuItem.Click += new System.EventHandler(this.phépTrừuToolStripMenuItem_Click);
            // 
            // trắcNghiệmHìnhHọcToolStripMenuItem
            // 
            this.trắcNghiệmHìnhHọcToolStripMenuItem.Name = "trắcNghiệmHìnhHọcToolStripMenuItem";
            this.trắcNghiệmHìnhHọcToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.trắcNghiệmHìnhHọcToolStripMenuItem.Text = "Trắc nghiệm hình học";
            // 
            // toánĐốToolStripMenuItem
            // 
            this.toánĐốToolStripMenuItem.Name = "toánĐốToolStripMenuItem";
            this.toánĐốToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.toánĐốToolStripMenuItem.Text = "Toán đố";
            // 
            // soSánhToolStripMenuItem
            // 
            this.soSánhToolStripMenuItem.Name = "soSánhToolStripMenuItem";
            this.soSánhToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.soSánhToolStripMenuItem.Text = "So sánh";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 297);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Bài tập toán lớp 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem phépCộngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phépTrừuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phépCộng1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phépCộng2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trắcNghiệmHìnhHọcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toánĐốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soSánhToolStripMenuItem;
    }
}

