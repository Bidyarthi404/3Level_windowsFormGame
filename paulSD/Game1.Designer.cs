namespace paulSD
{
    partial class Game1
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
            components = new System.ComponentModel.Container();
            player = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ScoreLabel = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.run_down0;
            player.Location = new Point(208, 491);
            player.Name = "player";
            player.Size = new Size(108, 136);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 2;
            player.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.m1;
            pictureBox4.Location = new Point(280, -9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(169, 205);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "Obstacle";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.m2;
            pictureBox5.Location = new Point(624, 387);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(174, 225);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "Obstacle";
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.BackColor = Color.Transparent;
            ScoreLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            ScoreLabel.ForeColor = Color.White;
            ScoreLabel.Location = new Point(-1, -1);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(121, 38);
            ScoreLabel.TabIndex = 5;
            ScoreLabel.Text = "Score: 0";
            ScoreLabel.Click += ScoreLabel_Click;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimerEvent;
            // 
            // Game1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_still;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 603);
            Controls.Add(ScoreLabel);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(player);
            DoubleBuffered = true;
            Location = new Point(200, 100);
            Name = "Game1";
            Text = "Game1";
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox player;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label ScoreLabel;
        private System.Windows.Forms.Timer GameTimer;
    }
}