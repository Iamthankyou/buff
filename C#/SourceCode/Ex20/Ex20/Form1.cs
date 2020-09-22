using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex20
{
    public partial class Form1 : Form
    {
        private OpenFileDialog dlgOpen;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                rtb.LoadFile(dlgOpen.FileName,RichTextBoxStreamType.RichText);
            }
            else
            {
                MessageBox.Show("Not choose file!", "Open Dialog", MessageBoxButtons.OK);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dlgOpen.FileName == "")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.ShowDialog();

                if (saveFileDialog.FileName != "")
                {
                    saveFileDialog.InitialDirectory = "D:\\buff\\C#";
                    rtb.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                    MessageBox.Show("Saved", "Save file", MessageBoxButtons.OK);
                }
            }
            else
            {
                rtb.SaveFile(dlgOpen.FileName, RichTextBoxStreamType.RichText);
                MessageBox.Show("Saved", "Save file", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Rtf File(*.rtf)|*.rtf";
            dlgOpen.InitialDirectory = "D:\\buff\\C#";
            dlgOpen.Title = "Open file RTF";
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                rtb.Font = fontDialog.Font;
            }
            else
            {
                MessageBox.Show("Not choose font", "Change font", MessageBoxButtons.OK);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtb.ForeColor = colorDialog.Color;
            }
            else
            {
                MessageBox.Show("Not choose font", "Change font", MessageBoxButtons.OK);
            }
        }
    }
}
