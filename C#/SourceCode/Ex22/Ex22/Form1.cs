using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex22
{
    public partial class Form1 : Form
    {
        private int choose = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                textBoxOne.ContextMenuStrip = contextMenu;
                choose = 1;
            }
        }

        private void textBoxTwo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                textBoxTwo.ContextMenuStrip = contextMenu;
                choose = 2;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {
                Clipboard.SetText(textBoxOne.Text);
            }
            else
            {
                Clipboard.SetText(textBoxTwo.Text);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {
                textBoxOne.Text = textBoxOne.Text + Clipboard.GetText();
            }
            else
            {
                textBoxOne.Text = textBoxOne.Text + Clipboard.GetText();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (choose == 1)
            {
                textBoxOne.Cut();
            }
            else
            {
                textBoxTwo.Cut();
            }
        }
    }
}
