using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BettingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int char1, char2, char3, char4;
        private void Form1_Load(object sender, EventArgs e)
        {
            char1 = pictureBox1.Left;
            char2 = pictureBox2.Left;
            char3 = pictureBox3.Left;
            char4 = pictureBox4.Left;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int widthChar1 = pictureBox1.Width;
            int widthChar2 = pictureBox2.Width;
            int widthChar3 = pictureBox3.Width;
            int widthChar4 = pictureBox4.Width;
            int start = label2.Left;
            pictureBox1.Left = pictureBox1.Left + random.Next(5, 16);
            pictureBox2.Left = pictureBox2.Left + random.Next(5, 16);
            pictureBox3.Left = pictureBox3.Left + random.Next(5, 16);
            pictureBox4.Left = pictureBox4.Left + random.Next(5, 16);
            if (widthChar1 + pictureBox1.Left >= start) 
            {
                timer1.Enabled = false;
                label3.Text = "HORSE 1 WON THE RACE!";
            }
            else if (widthChar2 + pictureBox2.Left >= start)
            {
                timer1.Enabled = false;
                label3.Text = "HORSE 2 WON THE RACE!";
            }
            else if (widthChar3 + pictureBox3.Left >= start)
            {
                timer1.Enabled = false;
                label3.Text = "HORSE 3 WON THE RACE!";
            }
            else if (widthChar4 + pictureBox4.Left >= start)
            {
                timer1.Enabled = false;
                label3.Text = "HORSE 4 WON THE RACE!";
            }

        }
    }
}
