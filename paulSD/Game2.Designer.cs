namespace paulSD
{
    partial class Game2
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
            egg3 = new PictureBox();
            egg2 = new PictureBox();
            egg1 = new PictureBox();
            txtScore = new Label();
            GameTimer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)egg3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)egg2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)egg1).BeginInit();
            SuspendLayout();
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Image = Properties.Resources.start_prince;
            player.Location = new Point(512, 380);
            player.Name = "player";
            player.Size = new Size(104, 226);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 0;
            player.TabStop = false;
            player.Tag = "player";
            player.Click += player_Click;
            // 
            // egg3
            // 
            egg3.BackColor = Color.Transparent;
            egg3.Image = Properties.Resources.Bomb;
            egg3.Location = new Point(883, 63);
            egg3.Name = "egg3";
            egg3.Size = new Size(56, 72);
            egg3.SizeMode = PictureBoxSizeMode.StretchImage;
            egg3.TabIndex = 1;
            egg3.TabStop = false;
            egg3.Tag = "bomb";
            // 
            // egg2
            // 
            egg2.BackColor = Color.Transparent;
            egg2.Image = Properties.Resources.Bomb;
            egg2.Location = new Point(496, 63);
            egg2.Name = "egg2";
            egg2.Size = new Size(56, 72);
            egg2.SizeMode = PictureBoxSizeMode.StretchImage;
            egg2.TabIndex = 2;
            egg2.TabStop = false;
            egg2.Tag = "bomb";
            // 
            // egg1
            // 
            egg1.BackColor = Color.Transparent;
            egg1.Image = Properties.Resources.key;
            egg1.Location = new Point(97, 63);
            egg1.Name = "egg1";
            egg1.Size = new Size(56, 72);
            egg1.SizeMode = PictureBoxSizeMode.StretchImage;
            egg1.TabIndex = 3;
            egg1.TabStop = false;
            egg1.Tag = "key";
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.BackColor = Color.Transparent;
            txtScore.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtScore.ForeColor = SystemColors.Control;
            txtScore.Location = new Point(-1, -1);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(128, 41);
            txtScore.TabIndex = 4;
            txtScore.Text = "Score: 0";
            txtScore.Click += label1_Click;
            // 
            // GameTimer2
            // 
            GameTimer2.Tick += GameTimer2Event;
            // 
            // Game2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Level2BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 603);
            Controls.Add(txtScore);
            Controls.Add(egg1);
            Controls.Add(egg2);
            Controls.Add(egg3);
            Controls.Add(player);
            DoubleBuffered = true;
            Location = new Point(200, 100);
            Name = "Game2";
            Text = "Game2";
            KeyDown += KeyisDown;
            KeyUp += KeyisUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)egg3).EndInit();
            ((System.ComponentModel.ISupportInitialize)egg2).EndInit();
            ((System.ComponentModel.ISupportInitialize)egg1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox player;
        private PictureBox egg3;
        private PictureBox egg2;
        private PictureBox egg1;
        private Label txtScore;
        private Label txtMissed;
        private System.Windows.Forms.Timer GameTimer2;
    }
}