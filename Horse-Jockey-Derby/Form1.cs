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
using System.Media;

namespace Horse_Jockey_Derby
{
    public partial class Form1 : Form
    {
        // Sound players for various audio effects
        SoundPlayer bgMusic;
        SoundPlayer clickAudio;
        SoundPlayer winAudio;
        SoundPlayer loseAudio;
        public Form1()
        {
            InitializeComponent();
            // Set window properties
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Initialize sound players with audio files
            bgMusic = new SoundPlayer("bg-music.wav");
            clickAudio = new SoundPlayer("mouse-click.wav");
            winAudio = new SoundPlayer("yay.wav");
            loseAudio = new SoundPlayer("aww.wav");

            // Play background music
            bgMusic.Play();
        }

        // Integers to store starting position and store player's bet
        int blueHorse, greenHorse, orangeHorse, purpleHorse, redHorse;
        string bet;
        int playerMoney = 500;
        int betAmount;
        Random random = new Random();

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            // Play click audio when continue button is clicked
            clickAudio.Play();
            bgMusic.Play();
            // Hide result panel and reset bet and label text
            panelResult.Visible = false;
            bet = "";
            labelBet.Text = "";
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
            // Play click audio when bet button is clicked
            clickAudio.Play();

            // Check if no bet is selected and show error message
            if (string.IsNullOrWhiteSpace(textBoxBetAmount.Text))
            {
                MessageBox.Show("Please enter a bet amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBoxBetAmount.Text, out int betAmount) || betAmount < 0)
            {
                MessageBox.Show("Bet amount must be positive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (betAmount > playerMoney)
            {
                MessageBox.Show("Bet amount is bigger than your current money.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (playerMoney <= 0)
            {
                MessageBox.Show("Insufficient Funds!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!selectBlue.Checked && !selectOrange.Checked && !selectPurple.Checked && !selectRed.Checked && !selectGreen.Checked)
            {
                MessageBox.Show("Select horse!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedHorse = "";
            if (selectBlue.Checked)
                selectedHorse = "Azure Arrow";
            else if (selectGreen.Checked)
                selectedHorse = "Emerald Eclipse";
            else if (selectOrange.Checked)
                selectedHorse = "Citrus Comet";
            else if (selectPurple.Checked)
                selectedHorse = "Amethyst Ace";
            else if (selectRed.Checked)
                selectedHorse = "Scarlet Spear";

            if (selectedHorse == null)
            {
                MessageBox.Show("Select horse!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Assign the selected horse to the bet variable
            bet = selectedHorse;

            // Update the global betAmount variable
            this.betAmount = betAmount;

            // Set bet label text and start race timer
            labelBet.Text = $"{selectedHorse} ${betAmount}";
            timer1.Enabled = true;
            // Hide betting panel
            panelBet.Visible = false;
            labelMoney.Text = $"${playerMoney}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Show money at start
            labelMoney.Text = $"${playerMoney}";

            // Hide welcome panel
            panelWelcome.Visible = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Stop background music and play in-game audio
            bgMusic.Stop();

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
                labelHorseWinner.Text = "Azure Arrow WINS!";
                WinningHorse(bet == "Azure Arrow");
                panelResult.Visible = true;
                labelMoney.Text = $"${playerMoney}";
            }
            else if (width_greenHorse + pictureBox2.Left + 5 >= start)
            {
                timer1.Stop();
                labelHorseWinner.Text = "Emerald Eclipse WINS!";
                WinningHorse(bet == "Emerald Eclipse");
                panelResult.Visible = true;
                labelMoney.Text = $"${playerMoney}";
            }
            else if (width_orangeHorse + pictureBox3.Left >= start)
            {
                timer1.Stop();
                labelHorseWinner.Text = "Citrus Comet WINS!";
                WinningHorse(bet == "Citrus Comet");
                panelResult.Visible = true;
                labelMoney.Text = $"${playerMoney}";
            }
            else if (width_purpleHorse + pictureBox4.Left >= start)
            {
                timer1.Stop();
                labelHorseWinner.Text = "Amethyst Ace WINS!";
                WinningHorse(bet == "Amethyst Ace");
                panelResult.Visible = true;
                labelMoney.Text = $"${playerMoney}";
            }
            else if (width_redHorse + pictureBox5.Left >= start)
            {
                timer1.Stop();
                labelHorseWinner.Text = "Scaret Spear WINS!";
                WinningHorse(bet == "Scarlet Spear");
                panelResult.Visible = true;
                labelMoney.Text = $"${playerMoney}";
            }
        }

        private void WinningHorse(bool isWinner)
        {
            // Update result label based on win/lose
            if (isWinner)
            {
                winAudio.Play();
                labelResult.Text = "WINNER!";
                playerMoney += betAmount;
                labelTotalGained.Text = "Gained +$" + betAmount;
                labelResultMoney.Text = "Total Money: " + playerMoney;
            }
            else
            {
                loseAudio.Play();
                labelResult.Text = "LOSER!";
                playerMoney -= betAmount;
                labelTotalGained.Text = "Loss -$" + betAmount;
                labelResultMoney.Text = "Total Money: $" + playerMoney;
            }

            if (playerMoney <= 0)
            {
                MessageBox.Show("Insufficient Funds!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

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

