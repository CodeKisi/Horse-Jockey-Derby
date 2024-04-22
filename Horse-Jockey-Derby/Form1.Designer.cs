namespace Horse_Jockey_Derby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelFinish = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panelBet = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBetAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectRed = new System.Windows.Forms.RadioButton();
            this.selectPurple = new System.Windows.Forms.RadioButton();
            this.selectOrange = new System.Windows.Forms.RadioButton();
            this.selectGreen = new System.Windows.Forms.RadioButton();
            this.selectBlue = new System.Windows.Forms.RadioButton();
            this.labelBet = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.labelTotalGained = new System.Windows.Forms.Label();
            this.labelResultMoney = new System.Windows.Forms.Label();
            this.labelHorseWinner = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.panelWelcome = new System.Windows.Forms.Panel();
            this.play = new System.Windows.Forms.Button();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panelBet.SuspendLayout();
            this.panelResult.SuspendLayout();
            this.panelWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::Horse_Jockey_Derby.Properties.Resources.blue_horse_crop;
            this.pictureBox1.Location = new System.Drawing.Point(46, 44);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Horse_Jockey_Derby.Properties.Resources.green_horse_crop;
            this.pictureBox2.Location = new System.Drawing.Point(46, 124);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Horse_Jockey_Derby.Properties.Resources.orange_horse_crop;
            this.pictureBox3.Location = new System.Drawing.Point(46, 204);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(83, 63);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Horse_Jockey_Derby.Properties.Resources.purple_horse_crop;
            this.pictureBox4.Location = new System.Drawing.Point(46, 285);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(83, 63);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::Horse_Jockey_Derby.Properties.Resources.red_horse_crop;
            this.pictureBox5.Location = new System.Drawing.Point(46, 365);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(83, 63);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // panelFinish
            // 
            this.panelFinish.BackColor = System.Drawing.Color.Transparent;
            this.panelFinish.Location = new System.Drawing.Point(826, 44);
            this.panelFinish.Margin = new System.Windows.Forms.Padding(2);
            this.panelFinish.Name = "panelFinish";
            this.panelFinish.Size = new System.Drawing.Size(20, 391);
            this.panelFinish.TabIndex = 8;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Gold;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(291, 306);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(92, 31);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelBet
            // 
            this.panelBet.BackColor = System.Drawing.Color.Transparent;
            this.panelBet.BackgroundImage = global::Horse_Jockey_Derby.Properties.Resources.bet_selection__Small_;
            this.panelBet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelBet.Controls.Add(this.label2);
            this.panelBet.Controls.Add(this.textBoxBetAmount);
            this.panelBet.Controls.Add(this.label1);
            this.panelBet.Controls.Add(this.selectRed);
            this.panelBet.Controls.Add(this.selectPurple);
            this.panelBet.Controls.Add(this.selectOrange);
            this.panelBet.Controls.Add(this.selectGreen);
            this.panelBet.Controls.Add(this.selectBlue);
            this.panelBet.Controls.Add(this.buttonStart);
            this.panelBet.Location = new System.Drawing.Point(188, 44);
            this.panelBet.Margin = new System.Windows.Forms.Padding(2);
            this.panelBet.Name = "panelBet";
            this.panelBet.Size = new System.Drawing.Size(577, 379);
            this.panelBet.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(84, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 22;
            this.label2.Text = "Bet amount";
            // 
            // textBoxBetAmount
            // 
            this.textBoxBetAmount.Location = new System.Drawing.Point(178, 312);
            this.textBoxBetAmount.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBetAmount.Name = "textBoxBetAmount";
            this.textBoxBetAmount.Size = new System.Drawing.Size(94, 20);
            this.textBoxBetAmount.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select Horse";
            // 
            // selectRed
            // 
            this.selectRed.AutoSize = true;
            this.selectRed.Location = new System.Drawing.Point(345, 207);
            this.selectRed.Margin = new System.Windows.Forms.Padding(2);
            this.selectRed.Name = "selectRed";
            this.selectRed.Size = new System.Drawing.Size(14, 13);
            this.selectRed.TabIndex = 19;
            this.selectRed.TabStop = true;
            this.selectRed.UseVisualStyleBackColor = true;
            // 
            // selectPurple
            // 
            this.selectPurple.AutoSize = true;
            this.selectPurple.Location = new System.Drawing.Point(214, 207);
            this.selectPurple.Margin = new System.Windows.Forms.Padding(2);
            this.selectPurple.Name = "selectPurple";
            this.selectPurple.Size = new System.Drawing.Size(14, 13);
            this.selectPurple.TabIndex = 18;
            this.selectPurple.TabStop = true;
            this.selectPurple.UseVisualStyleBackColor = true;
            // 
            // selectOrange
            // 
            this.selectOrange.AutoSize = true;
            this.selectOrange.Location = new System.Drawing.Point(414, 84);
            this.selectOrange.Margin = new System.Windows.Forms.Padding(2);
            this.selectOrange.Name = "selectOrange";
            this.selectOrange.Size = new System.Drawing.Size(14, 13);
            this.selectOrange.TabIndex = 17;
            this.selectOrange.TabStop = true;
            this.selectOrange.UseVisualStyleBackColor = true;
            // 
            // selectGreen
            // 
            this.selectGreen.AutoSize = true;
            this.selectGreen.Location = new System.Drawing.Point(282, 84);
            this.selectGreen.Margin = new System.Windows.Forms.Padding(2);
            this.selectGreen.Name = "selectGreen";
            this.selectGreen.Size = new System.Drawing.Size(14, 13);
            this.selectGreen.TabIndex = 16;
            this.selectGreen.TabStop = true;
            this.selectGreen.UseVisualStyleBackColor = true;
            // 
            // selectBlue
            // 
            this.selectBlue.AutoSize = true;
            this.selectBlue.Location = new System.Drawing.Point(152, 84);
            this.selectBlue.Margin = new System.Windows.Forms.Padding(2);
            this.selectBlue.Name = "selectBlue";
            this.selectBlue.Size = new System.Drawing.Size(14, 13);
            this.selectBlue.TabIndex = 15;
            this.selectBlue.TabStop = true;
            this.selectBlue.UseVisualStyleBackColor = true;
            // 
            // labelBet
            // 
            this.labelBet.AutoSize = true;
            this.labelBet.BackColor = System.Drawing.Color.Transparent;
            this.labelBet.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelBet.Location = new System.Drawing.Point(105, 453);
            this.labelBet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBet.Name = "labelBet";
            this.labelBet.Size = new System.Drawing.Size(0, 36);
            this.labelBet.TabIndex = 11;
            this.labelBet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.Red;
            this.panelResult.Controls.Add(this.labelTotalGained);
            this.panelResult.Controls.Add(this.labelResultMoney);
            this.panelResult.Controls.Add(this.labelHorseWinner);
            this.panelResult.Controls.Add(this.buttonContinue);
            this.panelResult.Controls.Add(this.labelResult);
            this.panelResult.Location = new System.Drawing.Point(171, 54);
            this.panelResult.Margin = new System.Windows.Forms.Padding(2);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(575, 381);
            this.panelResult.TabIndex = 20;
            this.panelResult.Visible = false;
            // 
            // labelTotalGained
            // 
            this.labelTotalGained.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalGained.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalGained.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTotalGained.Location = new System.Drawing.Point(31, 174);
            this.labelTotalGained.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalGained.Name = "labelTotalGained";
            this.labelTotalGained.Size = new System.Drawing.Size(521, 72);
            this.labelTotalGained.TabIndex = 4;
            this.labelTotalGained.Text = "hmm...";
            this.labelTotalGained.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelResultMoney
            // 
            this.labelResultMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelResultMoney.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultMoney.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelResultMoney.Location = new System.Drawing.Point(31, 235);
            this.labelResultMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResultMoney.Name = "labelResultMoney";
            this.labelResultMoney.Size = new System.Drawing.Size(521, 72);
            this.labelResultMoney.TabIndex = 3;
            this.labelResultMoney.Text = "hmm...";
            this.labelResultMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHorseWinner
            // 
            this.labelHorseWinner.BackColor = System.Drawing.Color.Transparent;
            this.labelHorseWinner.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorseWinner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHorseWinner.Location = new System.Drawing.Point(31, 102);
            this.labelHorseWinner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHorseWinner.Name = "labelHorseWinner";
            this.labelHorseWinner.Size = new System.Drawing.Size(521, 72);
            this.labelHorseWinner.TabIndex = 2;
            this.labelHorseWinner.Text = "hmm...";
            this.labelHorseWinner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.Gold;
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonContinue.Location = new System.Drawing.Point(232, 319);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(123, 43);
            this.buttonContinue.TabIndex = 1;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.Transparent;
            this.labelResult.Font = new System.Drawing.Font("Unispace", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelResult.Location = new System.Drawing.Point(114, 28);
            this.labelResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(371, 72);
            this.labelResult.TabIndex = 0;
            this.labelResult.Text = "hmm...";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWelcome
            // 
            this.panelWelcome.BackColor = System.Drawing.Color.Red;
            this.panelWelcome.Controls.Add(this.play);
            this.panelWelcome.Controls.Add(this.labelWelcome);
            this.panelWelcome.Location = new System.Drawing.Point(173, 44);
            this.panelWelcome.Margin = new System.Windows.Forms.Padding(2);
            this.panelWelcome.Name = "panelWelcome";
            this.panelWelcome.Size = new System.Drawing.Size(608, 419);
            this.panelWelcome.TabIndex = 21;
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Gold;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.play.Location = new System.Drawing.Point(225, 310);
            this.play.Margin = new System.Windows.Forms.Padding(2);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(123, 43);
            this.play.TabIndex = 1;
            this.play.Text = "Play";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelWelcome
            // 
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Unispace", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelWelcome.Location = new System.Drawing.Point(24, 29);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(510, 249);
            this.labelWelcome.TabIndex = 0;
            this.labelWelcome.Text = "Welcome to Horse Jockey Derby!";
            this.labelWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.BackColor = System.Drawing.Color.Transparent;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMoney.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelMoney.Location = new System.Drawing.Point(612, 453);
            this.labelMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(0, 36);
            this.labelMoney.TabIndex = 22;
            this.labelMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Horse_Jockey_Derby.Properties.Resources.horse_jockey_derby_bg_sized;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(886, 541);
            this.Controls.Add(this.panelWelcome);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelBet);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.labelBet);
            this.Controls.Add(this.panelFinish);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Horse Jockey Derby";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panelBet.ResumeLayout(false);
            this.panelBet.PerformLayout();
            this.panelResult.ResumeLayout(false);
            this.panelWelcome.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelFinish;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panelBet;
        private System.Windows.Forms.RadioButton selectBlue;
        private System.Windows.Forms.RadioButton selectRed;
        private System.Windows.Forms.RadioButton selectPurple;
        private System.Windows.Forms.RadioButton selectOrange;
        private System.Windows.Forms.RadioButton selectGreen;
        private System.Windows.Forms.Label labelBet;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHorseWinner;
        private System.Windows.Forms.Panel panelWelcome;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Label labelResultMoney;
        private System.Windows.Forms.Label labelTotalGained;
        private System.Windows.Forms.TextBox textBoxBetAmount;
        private System.Windows.Forms.Label label2;
    }
}

