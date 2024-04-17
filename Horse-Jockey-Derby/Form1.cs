using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Horse_Jockey_Derby
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        // Integers to store starting position and store player's bet
        int blueHorse, greenHorse, orangeHorse, purpleHorse, redHorse;
        string bet;

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            // Hide result panel and reset bet and label text
            panelResult.Visible = false;
            bet = "";
            labelBet.Text = "";
            labelWinner.Text = "";
            labelResult.Text = "";

            // Show betting panel
            panelBet.Visible = true;

            // reset starting positions of horse pictures based on stored values
            pictureBox1.Left = blueHorse;
            pictureBox2.Left = greenHorse;
            pictureBox3.Left = orangeHorse;
            pictureBox4.Left = purpleHorse;
            pictureBox5.Left = redHorse;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if no bet is selected and show error message
            if (!selectBlue.Checked && !selectOrange.Checked && !selectPurple.Checked && !selectRed.Checked && !selectGreen.Checked)
            {
                MessageBox.Show("Select bet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Determine bet based on selected radio button
                if (selectBlue.Checked)
                {
                    bet = "Azure Arrow";
                }
                else if (selectGreen.Checked)
                {
                    bet = "Emerald Eclipse";
                }
                else if (selectOrange.Checked)
                {
                    bet = "Citrus Comet";
                }
                else if (selectPurple.Checked)
                {
                    bet = "Amethyst Ace";
                }
                else if (selectRed.Checked)
                {
                    bet = "Scarlet Spear";
                }
                // Set bet label text and start race timer  
                labelBet.Text = bet;
                timer1.Enabled = true;
                // Hide betting panel
                panelBet.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hide welcome panel
            panelWelcome.Visible = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Get widths of horse pictures for finish line comparison
            int width_blueHorse = pictureBox1.Width;
            int width_greenHorse = pictureBox2.Width;
            int width_orangeHorse = pictureBox3.Width;
            int width_purpleHorse = pictureBox4.Width;
            int width_redHorse = pictureBox5.Width;
            // Get starting position of finish line
            int start = panelFinish.Left;

            // Move each horse picture by a random distance within a range
            pictureBox1.Left += random.Next(5, 16);
            pictureBox2.Left += random.Next(5, 16);
            pictureBox3.Left += random.Next(5, 16);
            pictureBox4.Left += random.Next(5, 16);
            pictureBox5.Left += random.Next(5, 16);

            // Check if a horse has crossed the finish line 
            if (width_blueHorse + pictureBox1.Left >= start)
            {
                // Stop timer, display winner text, and update result based on bet
                timer1.Stop();
                labelWinner.Text = "Azure Arrow WINS!";
                labelHorseWinner.Text = "Azure Arrow WINS!";
                WinningHorse(bet == "Azure Arrow");
                panelResult.Visible = true;
            }
            else if (width_greenHorse + pictureBox2.Left + 5 >= start)
            {
                timer1.Stop();
                labelWinner.Text = "Emerald Eclipse WINS!";
                labelHorseWinner.Text = "Emerald Eclipse WINS!";
                WinningHorse(bet == "Emerald Eclipse");
                panelResult.Visible = true;
            }
            else if (width_orangeHorse + pictureBox3.Left >= start)
            {
                timer1.Stop();
                labelWinner.Text = "Citrus Comet WINS!";
                labelHorseWinner.Text = "Citrus Comet WINS!";
                WinningHorse(bet == "Citrus Comet");
                panelResult.Visible = true;
            }
            else if (width_purpleHorse + pictureBox4.Left >= start)
            {
                timer1.Stop();
                labelWinner.Text = "Amethyst Ace WINS!";
                labelHorseWinner.Text = "Amethyst Ace WINS!";
                WinningHorse(bet == "Amethyst Ace");
                panelResult.Visible = true;
            }
            else if (width_redHorse + pictureBox5.Left >= start)
            {
                timer1.Stop();
                labelWinner.Text = "Scaret Spear WINS!";
                labelHorseWinner.Text = "Scaret Spear WINS!";
                WinningHorse(bet == "Scarlet Spear");
                panelResult.Visible = true;
            }
        }

        private void WinningHorse(bool isWinner)
        {
            // Update result label based on win/lose
            if (isWinner)
            {
                labelResult.Text = "WINNER!";
            }
            else
            {
                labelResult.Text = "LOSER!";
            }
        }

        Random random = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            // Store initial positions of horses
            blueHorse = pictureBox1.Left;
            greenHorse = pictureBox2.Left;
            orangeHorse = pictureBox3.Left;
            purpleHorse = pictureBox4.Left;
            redHorse = pictureBox5.Left;
        }
    }
}
