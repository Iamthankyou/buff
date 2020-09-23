namespace Ex22
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
            this.components = new System.ComponentModel.Container();
            this.lbLineOne = new System.Windows.Forms.Label();
            this.lbLineTwo = new System.Windows.Forms.Label();
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxOne = new System.Windows.Forms.RichTextBox();
            this.textBoxTwo = new System.Windows.Forms.RichTextBox();
            this.contextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLineOne
            // 
            this.lbLineOne.AutoSize = true;
            this.lbLineOne.Location = new System.Drawing.Point(63, 71);
            this.lbLineOne.Name = "lbLineOne";
            this.lbLineOne.Size = new System.Drawing.Size(59, 13);
            this.lbLineOne.TabIndex = 0;
            this.lbLineOne.Text = "Văn bản 1:";
            // 
            // lbLineTwo
            // 
            this.lbLineTwo.AutoSize = true;
            this.lbLineTwo.Location = new System.Drawing.Point(63, 218);
            this.lbLineTwo.Name = "lbLineTwo";
            this.lbLineTwo.Size = new System.Drawing.Size(59, 13);
            this.lbLineTwo.TabIndex = 1;
            this.lbLineTwo.Text = "Văn bản 2:";
            // 
            // contextMenu
            // 
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.Size = new System.Drawing.Size(181, 92);
            this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // textBoxOne
            // 
            this.textBoxOne.Location = new System.Drawing.Point(128, 33);
            this.textBoxOne.Name = "textBoxOne";
            this.textBoxOne.Size = new System.Drawing.Size(247, 96);
            this.textBoxOne.TabIndex = 5;
            this.textBoxOne.Text = "";
            this.textBoxOne.MouseClick += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseClick);
            this.textBoxOne.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // textBoxTwo
            // 
            this.textBoxTwo.Location = new System.Drawing.Point(128, 175);
            this.textBoxTwo.Name = "textBoxTwo";
            this.textBoxTwo.Size = new System.Drawing.Size(247, 96);
            this.textBoxTwo.TabIndex = 6;
            this.textBoxTwo.Text = "";
            this.textBoxTwo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxTwo_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 322);
            this.Controls.Add(this.textBoxTwo);
            this.Controls.Add(this.textBoxOne);
            this.Controls.Add(this.lbLineTwo);
            this.Controls.Add(this.lbLineOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLineOne;
        private System.Windows.Forms.Label lbLineTwo;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBoxOne;
        private System.Windows.Forms.RichTextBox textBoxTwo;
    }
}

