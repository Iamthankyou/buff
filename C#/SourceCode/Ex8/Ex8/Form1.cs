using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            textBox.BackColor = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Text = "Ea praesent dolor consetetur hendrerit gubergren dolores et sed sed ea sit gubergren rebum molestie eirmod sit ut elitr sea";
        }

        private void radioButtonFontArial_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font("Arial",15);
        }

        private void radioButtonLucida_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font("Lucida", 15);
        }

        private void radioButtonMagneto_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font("Magneto", 15);
        }

        private void radioButtonMonotype_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font("Monotype", 15);
        }

        private void checkBoxEffectBold_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font, FontStyle.Bold);
        }

        private void checkBoxItalic_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font, FontStyle.Italic);
        }

        private void checkBoxStrikeout_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font, FontStyle.Strikeout);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            textBox.Font = new Font(textBox.Font, FontStyle.Underline);
        }

        private void radioButtonFontRed_CheckedChanged(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.Red;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.DarkBlue;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            textBox.ForeColor = Color.Green;
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            textBox.Font = new Font("Microsoft Sans Serif", 15);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
