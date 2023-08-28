namespace paulSD
{
    partial class Game3
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            finalbtn = new PictureBox();
            StartButton = new Button();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)finalbtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(24, 497);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 78);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(89, 515);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(619, 45);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(252, 376);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(558, 35);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(668, 405);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(40, 123);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(191, 280);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(619, 29);
            pictureBox5.TabIndex = 4;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(229, 288);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 123);
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // finalbtn
            // 
            finalbtn.BackColor = Color.Transparent;
            finalbtn.Image = Properties.Resources.fairy;
            finalbtn.Location = new Point(279, 79);
            finalbtn.Name = "finalbtn";
            finalbtn.Size = new Size(73, 123);
            finalbtn.SizeMode = PictureBoxSizeMode.StretchImage;
            finalbtn.TabIndex = 6;
            finalbtn.TabStop = false;
            finalbtn.Tag = "finalbtn";
            finalbtn.MouseEnter += ShowScreenWindow;
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.YellowGreen;
            StartButton.ForeColor = Color.Ivory;
            StartButton.Location = new Point(24, 497);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(76, 78);
            StartButton.TabIndex = 7;
            StartButton.Tag = "StartButton";
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = false;
            StartButton.Click += StartbuttonEvent;
            // 
            // pictureBox7
            // 
            pictureBox7.Location = new Point(279, 186);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(619, 16);
            pictureBox7.TabIndex = 8;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Location = new Point(786, 186);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(24, 123);
            pictureBox8.TabIndex = 9;
            pictureBox8.TabStop = false;
            // 
            // Game3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.maze;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 603);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox7);
            Controls.Add(StartButton);
            Controls.Add(finalbtn);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Location = new Point(200, 100);
            Name = "Game3";
            Text = "Game3";
            MouseEnter += EnterMouseEvent;
            MouseHover += EnterMouseEvent;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)finalbtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox finalbtn;
        private Button StartButton;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
    }
}