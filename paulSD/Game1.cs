using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paulSD
{
    public partial class Game1 : Form
    {
        SoundPlayer player1 = new SoundPlayer();
        // global variables
        int gravity;
        int gravityValue = 20;
        int obstacleSpeed = 10;
        int score = 0;
        //int highScore = 0;
        bool gameOver = false;
        Random random = new Random();
        public Game1()
        {
            InitializeComponent();
            RestartGame();
        }
        private void GameTimerEvent(object sender, EventArgs e)
        {
            ScoreLabel.Text = "Score: " + score;

            player.Top += gravity;
            // when the player land on the platforms. 
            if (player.Top > 491)
            {
                gravity = 0;
                player.Top = 491;
                player.Image = Properties.Resources.run_down0;
            }
            else if (player.Top < -24)
            {
                gravity = 0;
                player.Top = -24;
                player.Image = Properties.Resources.run_up0;
            }
            // move the obstacles
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Obstacle")
                {
                    x.Left -= obstacleSpeed;
                    if (x.Left < -100)
                    {
                        x.Left = random.Next(1200, 3000);
                        score += 1;
                    }

                    if (x.Bounds.IntersectsWith(player.Bounds))
                    {
                        GameTimer.Stop();
                        ScoreLabel.Text += " Game Over!! Press Enter to Try Again.";
                        gameOver = true;

                    }
                }
            }
            // increase the speed of player and obstacles
            if (score > 10)
            {
                obstacleSpeed = 20;
                gravityValue = 25;
            }

            if (score > 1)
            {
                GameTimer.Stop();
                this.Hide();
                player1.Stop();
                Game1ToGame2 temp1 = new Game1ToGame2();
                temp1.Show();
            }

        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (player.Top == 491)
                {
                    player.Top -= 10;
                    gravity = -gravityValue;
                }
                else if (player.Top == -24)
                {
                    player.Top += 10;
                    gravity = gravityValue;
                }
            }
            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }
        private void RestartGame()
        {
            player.Location = new Point(208, 491);
            player.Image = Properties.Resources.run_down0;
            score = 0;
            gravityValue = 20;
            gravity = gravityValue;
            obstacleSpeed = 10;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "Obstacle")
                {
                    x.Left = random.Next(1200, 3000);
                }
            }
            player1.Stream = Properties.Resources.music;
            player1.PlayLooping();
            GameTimer.Start();
        }

        private void ScoreLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
