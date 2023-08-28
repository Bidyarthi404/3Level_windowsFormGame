namespace paulSD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Start;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Tomato;
            button1.Location = new Point(342, 423);
            button1.Name = "button1";
            button1.Size = new Size(391, 123);
            button1.TabIndex = 0;
            button1.Text = "Begin Your Journey";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Rockwell", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(179, 155);
            label1.Name = "label1";
            label1.Size = new Size(737, 42);
            label1.TabIndex = 1;
            label1.Text = "A Journey of Hogwarts Prince And His Fairy";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Rockwell", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(352, 62);
            label2.Name = "label2";
            label2.Size = new Size(363, 73);
            label2.TabIndex = 2;
            label2.Text = "B.I.R.D.I.E";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.start_prince;
            pictureBox1.Location = new Point(287, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.fairy;
            pictureBox2.Location = new Point(721, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(108, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(48, 263);
            label3.Name = "label3";
            label3.Size = new Size(543, 31);
            label3.TabIndex = 5;
            label3.Text = "Hey Prince, your Birdie got kidnapped by a Troll. ";
            label3.TextAlign = ContentAlignment.BottomCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(48, 291);
            label4.Name = "label4";
            label4.Size = new Size(516, 31);
            label4.TabIndex = 6;
            label4.Text = "You have to save her before the king finds out!";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.SandyBrown;
            label5.Location = new Point(48, 225);
            label5.Name = "label5";
            label5.Size = new Size(175, 38);
            label5.TabIndex = 7;
            label5.Text = "Disclaimer: ";
            label5.TextAlign = ContentAlignment.BottomCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.troll;
            pictureBox3.Location = new Point(782, 306);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(218, 267);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            BackgroundImage = Properties.Resources.Start;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 603);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Location = new Point(200, 100);
            Name = "Form1";
            Text = "Start Window";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox3;
    }
}