using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            imageSlider1.Size = new Size(200, 400);
            imageSlider1.Images.Add(Image.FromFile("F:\\img1.png"));
            imageSlider1.Images.Add(Image.FromFile("F:\\img2.png"));
        }
    }
}
