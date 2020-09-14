using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcClass01
{
    public partial class Form1 : Form
    {
        private int counter = 330;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerCountDown.Interval = 1000;
            timerCountDown.Start();
            
        }

        private void textBoxMinutes_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxMinutes.Text = "5";
            textBoxSecs.Text = "30";
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            if (counter-- == 0)
            {
                timerCountDown.Stop();
            }

            textBoxMinutes.Text = (counter / 60).ToString();
            textBoxSecs.Text = (counter % 60).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timerCountDown.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timerCountDown.Stop();
            counter = 330;

            textBoxMinutes.Text = (counter / 60).ToString();
            textBoxSecs.Text = (counter % 60).ToString();
        }
    }
}
