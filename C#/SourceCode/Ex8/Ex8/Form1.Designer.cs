namespace Ex8
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.groupBoxFont = new System.Windows.Forms.GroupBox();
            this.radioButtonMonotype = new System.Windows.Forms.RadioButton();
            this.radioButtonMagneto = new System.Windows.Forms.RadioButton();
            this.radioButtonLucida = new System.Windows.Forms.RadioButton();
            this.radioButtonFontArial = new System.Windows.Forms.RadioButton();
            this.groupBoxEffect = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBoxStrikeout = new System.Windows.Forms.CheckBox();
            this.checkBoxItalic = new System.Windows.Forms.CheckBox();
            this.checkBoxEffectBold = new System.Windows.Forms.CheckBox();
            this.groupBoxFontColor = new System.Windows.Forms.GroupBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButtonFontRed = new System.Windows.Forms.RadioButton();
            this.btnAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBoxFont.SuspendLayout();
            this.groupBoxEffect.SuspendLayout();
            this.groupBoxFontColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBox.Location = new System.Drawing.Point(88, 40);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(263, 30);
            this.textBox.TabIndex = 0;
            // 
            // groupBoxFont
            // 
            this.groupBoxFont.Controls.Add(this.radioButtonMonotype);
            this.groupBoxFont.Controls.Add(this.radioButtonMagneto);
            this.groupBoxFont.Controls.Add(this.radioButtonLucida);
            this.groupBoxFont.Controls.Add(this.radioButtonFontArial);
            this.groupBoxFont.Location = new System.Drawing.Point(23, 87);
            this.groupBoxFont.Name = "groupBoxFont";
            this.groupBoxFont.Size = new System.Drawing.Size(109, 127);
            this.groupBoxFont.TabIndex = 1;
            this.groupBoxFont.TabStop = false;
            this.groupBoxFont.Text = "Kiểu font";
            // 
            // radioButtonMonotype
            // 
            this.radioButtonMonotype.AutoSize = true;
            this.radioButtonMonotype.Font = new System.Drawing.Font("Monotype Corsiva", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMonotype.Location = new System.Drawing.Point(7, 96);
            this.radioButtonMonotype.Name = "radioButtonMonotype";
            this.radioButtonMonotype.Size = new System.Drawing.Size(66, 17);
            this.radioButtonMonotype.TabIndex = 3;
            this.radioButtonMonotype.TabStop = true;
            this.radioButtonMonotype.Text = "Monotype";
            this.radioButtonMonotype.UseVisualStyleBackColor = true;
            this.radioButtonMonotype.CheckedChanged += new System.EventHandler(this.radioButtonMonotype_CheckedChanged);
            // 
            // radioButtonMagneto
            // 
            this.radioButtonMagneto.AutoSize = true;
            this.radioButtonMagneto.Font = new System.Drawing.Font("Magneto", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMagneto.Location = new System.Drawing.Point(7, 72);
            this.radioButtonMagneto.Name = "radioButtonMagneto";
            this.radioButtonMagneto.Size = new System.Drawing.Size(76, 19);
            this.radioButtonMagneto.TabIndex = 2;
            this.radioButtonMagneto.TabStop = true;
            this.radioButtonMagneto.Text = "Magneto";
            this.radioButtonMagneto.UseVisualStyleBackColor = true;
            this.radioButtonMagneto.CheckedChanged += new System.EventHandler(this.radioButtonMagneto_CheckedChanged);
            // 
            // radioButtonLucida
            // 
            this.radioButtonLucida.AutoSize = true;
            this.radioButtonLucida.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLucida.Location = new System.Drawing.Point(7, 47);
            this.radioButtonLucida.Name = "radioButtonLucida";
            this.radioButtonLucida.Size = new System.Drawing.Size(70, 19);
            this.radioButtonLucida.TabIndex = 1;
            this.radioButtonLucida.TabStop = true;
            this.radioButtonLucida.Text = "Lucida";
            this.radioButtonLucida.UseVisualStyleBackColor = true;
            this.radioButtonLucida.CheckedChanged += new System.EventHandler(this.radioButtonLucida_CheckedChanged);
            // 
            // radioButtonFontArial
            // 
            this.radioButtonFontArial.AutoSize = true;
            this.radioButtonFontArial.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFontArial.Location = new System.Drawing.Point(7, 20);
            this.radioButtonFontArial.Name = "radioButtonFontArial";
            this.radioButtonFontArial.Size = new System.Drawing.Size(49, 16);
            this.radioButtonFontArial.TabIndex = 0;
            this.radioButtonFontArial.TabStop = true;
            this.radioButtonFontArial.Text = "Arial";
            this.radioButtonFontArial.UseVisualStyleBackColor = true;
            this.radioButtonFontArial.CheckedChanged += new System.EventHandler(this.radioButtonFontArial_CheckedChanged);
            // 
            // groupBoxEffect
            // 
            this.groupBoxEffect.Controls.Add(this.checkBox4);
            this.groupBoxEffect.Controls.Add(this.checkBoxStrikeout);
            this.groupBoxEffect.Controls.Add(this.checkBoxItalic);
            this.groupBoxEffect.Controls.Add(this.checkBoxEffectBold);
            this.groupBoxEffect.Location = new System.Drawing.Point(163, 87);
            this.groupBoxEffect.Name = "groupBoxEffect";
            this.groupBoxEffect.Size = new System.Drawing.Size(114, 127);
            this.groupBoxEffect.TabIndex = 2;
            this.groupBoxEffect.TabStop = false;
            this.groupBoxEffect.Text = "Hiệu ứng";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(7, 96);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(71, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Underline";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBoxStrikeout
            // 
            this.checkBoxStrikeout.AutoSize = true;
            this.checkBoxStrikeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStrikeout.Location = new System.Drawing.Point(7, 72);
            this.checkBoxStrikeout.Name = "checkBoxStrikeout";
            this.checkBoxStrikeout.Size = new System.Drawing.Size(68, 17);
            this.checkBoxStrikeout.TabIndex = 2;
            this.checkBoxStrikeout.Text = "Strikeout";
            this.checkBoxStrikeout.UseVisualStyleBackColor = true;
            this.checkBoxStrikeout.CheckedChanged += new System.EventHandler(this.checkBoxStrikeout_CheckedChanged);
            // 
            // checkBoxItalic
            // 
            this.checkBoxItalic.AutoSize = true;
            this.checkBoxItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxItalic.Location = new System.Drawing.Point(7, 47);
            this.checkBoxItalic.Name = "checkBoxItalic";
            this.checkBoxItalic.Size = new System.Drawing.Size(48, 17);
            this.checkBoxItalic.TabIndex = 1;
            this.checkBoxItalic.Text = "Italic";
            this.checkBoxItalic.UseVisualStyleBackColor = true;
            this.checkBoxItalic.CheckedChanged += new System.EventHandler(this.checkBoxItalic_CheckedChanged);
            // 
            // checkBoxEffectBold
            // 
            this.checkBoxEffectBold.AutoSize = true;
            this.checkBoxEffectBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEffectBold.Location = new System.Drawing.Point(7, 20);
            this.checkBoxEffectBold.Name = "checkBoxEffectBold";
            this.checkBoxEffectBold.Size = new System.Drawing.Size(51, 17);
            this.checkBoxEffectBold.TabIndex = 0;
            this.checkBoxEffectBold.Text = "Bold";
            this.checkBoxEffectBold.UseVisualStyleBackColor = true;
            this.checkBoxEffectBold.CheckedChanged += new System.EventHandler(this.checkBoxEffectBold_CheckedChanged);
            // 
            // groupBoxFontColor
            // 
            this.groupBoxFontColor.Controls.Add(this.radioButton8);
            this.groupBoxFontColor.Controls.Add(this.radioButton7);
            this.groupBoxFontColor.Controls.Add(this.radioButton6);
            this.groupBoxFontColor.Controls.Add(this.radioButtonFontRed);
            this.groupBoxFontColor.Location = new System.Drawing.Point(306, 87);
            this.groupBoxFontColor.Name = "groupBoxFontColor";
            this.groupBoxFontColor.Size = new System.Drawing.Size(116, 127);
            this.groupBoxFontColor.TabIndex = 3;
            this.groupBoxFontColor.TabStop = false;
            this.groupBoxFontColor.Text = "Màu chữ";
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.ForeColor = System.Drawing.Color.Blue;
            this.radioButton8.Location = new System.Drawing.Point(7, 96);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(54, 17);
            this.radioButton8.TabIndex = 3;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "Green";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.radioButton8_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.radioButton7.Location = new System.Drawing.Point(7, 72);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(46, 17);
            this.radioButton7.TabIndex = 2;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "Blue";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.radioButton7_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 47);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(48, 17);
            this.radioButton6.TabIndex = 1;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Dark";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButtonFontRed
            // 
            this.radioButtonFontRed.AutoSize = true;
            this.radioButtonFontRed.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonFontRed.ForeColor = System.Drawing.Color.Red;
            this.radioButtonFontRed.Location = new System.Drawing.Point(7, 20);
            this.radioButtonFontRed.Name = "radioButtonFontRed";
            this.radioButtonFontRed.Size = new System.Drawing.Size(45, 17);
            this.radioButtonFontRed.TabIndex = 0;
            this.radioButtonFontRed.TabStop = true;
            this.radioButtonFontRed.Text = "Red";
            this.radioButtonFontRed.UseVisualStyleBackColor = false;
            this.radioButtonFontRed.CheckedChanged += new System.EventHandler(this.radioButtonFontRed_CheckedChanged);
            // 
            // btnAgain
            // 
            this.btnAgain.Location = new System.Drawing.Point(110, 226);
            this.btnAgain.Name = "btnAgain";
            this.btnAgain.Size = new System.Drawing.Size(75, 23);
            this.btnAgain.TabIndex = 4;
            this.btnAgain.Text = "Làm lại";
            this.btnAgain.UseVisualStyleBackColor = true;
            this.btnAgain.Click += new System.EventHandler(this.btnAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(253, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAgain);
            this.Controls.Add(this.groupBoxFontColor);
            this.Controls.Add(this.groupBoxEffect);
            this.Controls.Add(this.groupBoxFont);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFont.ResumeLayout(false);
            this.groupBoxFont.PerformLayout();
            this.groupBoxEffect.ResumeLayout(false);
            this.groupBoxEffect.PerformLayout();
            this.groupBoxFontColor.ResumeLayout(false);
            this.groupBoxFontColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.GroupBox groupBoxFont;
        private System.Windows.Forms.RadioButton radioButtonMonotype;
        private System.Windows.Forms.RadioButton radioButtonMagneto;
        private System.Windows.Forms.RadioButton radioButtonLucida;
        private System.Windows.Forms.RadioButton radioButtonFontArial;
        private System.Windows.Forms.GroupBox groupBoxEffect;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBoxStrikeout;
        private System.Windows.Forms.CheckBox checkBoxItalic;
        private System.Windows.Forms.CheckBox checkBoxEffectBold;
        private System.Windows.Forms.GroupBox groupBoxFontColor;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButtonFontRed;
        private System.Windows.Forms.Button btnAgain;
        private System.Windows.Forms.Button btnExit;
    }
}

