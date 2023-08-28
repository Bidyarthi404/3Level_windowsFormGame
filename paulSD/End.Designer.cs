namespace paulSD
{
    partial class End
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
            CloseButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // CloseButton
            // 
            CloseButton.BackgroundImage = Properties.Resources.Start;
            CloseButton.ForeColor = Color.White;
            CloseButton.Location = new Point(12, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(127, 42);
            CloseButton.TabIndex = 0;
            CloseButton.Tag = "CloseButton";
            CloseButton.Text = "CloseButton";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.start_prince;
            pictureBox1.Location = new Point(336, 387);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(97, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.fairy;
            pictureBox2.Location = new Point(589, 387);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(146, 222);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(137, 239);
            label1.Name = "label1";
            label1.Size = new Size(816, 46);
            label1.TabIndex = 3;
            label1.Text = "You Have Retreived Your BIRDIE! Congratulations";
            // 
            // End
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Start;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 603);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(CloseButton);
            DoubleBuffered = true;
            Location = new Point(200, 100);
            Name = "End";
            Text = "End";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
    }
}