namespace EcClass01
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
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.textBoxSecs = new System.Windows.Forms.TextBox();
            this.lbTmp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxMinutes.ForeColor = System.Drawing.Color.Red;
            this.textBoxMinutes.Location = new System.Drawing.Point(99, 50);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(37, 38);
            this.textBoxMinutes.TabIndex = 0;
            this.textBoxMinutes.TextChanged += new System.EventHandler(this.textBoxMinutes_TextChanged);
            // 
            // textBoxSecs
            // 
            this.textBoxSecs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxSecs.ForeColor = System.Drawing.Color.Red;
            this.textBoxSecs.Location = new System.Drawing.Point(167, 51);
            this.textBoxSecs.Name = "textBoxSecs";
            this.textBoxSecs.Size = new System.Drawing.Size(36, 38);
            this.textBoxSecs.TabIndex = 1;
            // 
            // lbTmp
            // 
            this.lbTmp.AutoSize = true;
            this.lbTmp.Location = new System.Drawing.Point(145, 63);
            this.lbTmp.Name = "lbTmp";
            this.lbTmp.Size = new System.Drawing.Size(10, 13);
            this.lbTmp.TabIndex = 2;
            this.lbTmp.Text = ":";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Chạy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 106);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Tạm dừng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(209, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Làm lại";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timerCountDown
            // 
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 165);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbTmp);
            this.Controls.Add(this.textBoxSecs);
            this.Controls.Add(this.textBoxMinutes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.TextBox textBoxSecs;
        private System.Windows.Forms.Label lbTmp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timerCountDown;
    }
}

