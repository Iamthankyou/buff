namespace Ex4
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lbTextWaitInput = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.lbTextList = new System.Windows.Forms.Label();
            this.listEnglish = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTextWaitInput
            // 
            this.lbTextWaitInput.AutoSize = true;
            this.lbTextWaitInput.Location = new System.Drawing.Point(39, 47);
            this.lbTextWaitInput.Name = "lbTextWaitInput";
            this.lbTextWaitInput.Size = new System.Drawing.Size(104, 13);
            this.lbTextWaitInput.TabIndex = 0;
            this.lbTextWaitInput.Text = "Nhập tên ngoại ngữ:";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(166, 47);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(266, 20);
            this.txName.TabIndex = 1;
            this.txName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txName_KeyPress);
            // 
            // lbTextList
            // 
            this.lbTextList.AutoSize = true;
            this.lbTextList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbTextList.Location = new System.Drawing.Point(37, 90);
            this.lbTextList.Name = "lbTextList";
            this.lbTextList.Size = new System.Drawing.Size(271, 25);
            this.lbTextList.TabIndex = 2;
            this.lbTextList.Text = "Danh sách các tên ngoại ngữ:";
            // 
            // listEnglish
            // 
            this.listEnglish.FormattingEnabled = true;
            this.listEnglish.Location = new System.Drawing.Point(42, 126);
            this.listEnglish.Name = "listEnglish";
            this.listEnglish.Size = new System.Drawing.Size(390, 95);
            this.listEnglish.TabIndex = 3;
            this.listEnglish.SelectedIndexChanged += new System.EventHandler(this.listEnglish_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(42, 245);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(142, 245);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.btnDelete_GiveFeedback);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(242, 245);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(345, 245);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 280);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listEnglish);
            this.Controls.Add(this.lbTextList);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.lbTextWaitInput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lbTextWaitInput;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.Label lbTextList;
        private System.Windows.Forms.ListBox listEnglish;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
    }
}

