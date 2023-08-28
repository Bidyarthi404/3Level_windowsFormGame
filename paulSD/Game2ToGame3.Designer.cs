namespace paulSD
{
    partial class Game2ToGame3
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
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(267, 107);
            label1.Name = "label1";
            label1.Size = new Size(588, 38);
            label1.TabIndex = 0;
            label1.Text = "Congratulations! You Have Crossed level 2.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Tomato;
            label2.Location = new Point(99, 168);
            label2.Name = "label2";
            label2.Size = new Size(935, 38);
            label2.TabIndex = 1;
            label2.Text = "For the Final level you have to unlock the door to rescue your BIRDIE!";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Level2BG;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.PeachPuff;
            button1.Location = new Point(378, 366);
            button1.Name = "button1";
            button1.Size = new Size(424, 76);
            button1.TabIndex = 2;
            button1.Text = "Jump To The Final Level";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.start_prince;
            pictureBox1.Location = new Point(131, 209);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 413);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.key;
            pictureBox2.Location = new Point(851, 272);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(163, 265);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Game2ToGame3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Level2BG;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 603);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            ForeColor = Color.Salmon;
            Location = new Point(200, 100);
            Name = "Game2ToGame3";
            Text = "Game2ToGame3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}