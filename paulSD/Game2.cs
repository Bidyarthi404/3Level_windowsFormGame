using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paulSD
{

    public partial class Game2 : Form
    {
        SoundPlayer player1 = new SoundPlayer();
        bool goleft; // this boolean will be used to check if the player can move left
        bool goright; // this boolean will be used to check if the player can move right
        int speed = 8; // this is the default speed for the Eggs dropping
        int score = 0; // this is the default score value
        int missed = 0; // this is the default miss value
        Random rndY = new Random(); //this will be used to generate a random Y location
        Random rndX = new Random(); // this will be used to generate a random X location
        //PictureBox splash = new PictureBox(); // create a new splash picture box, this will added dynamically

        public Game2()
        {
            InitializeComponent();
            RestartGame();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimer2Event(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score; // show the score on Eggs Caught label
            //txtMissed.Text = "Missed: " + missed; // Show the misses on Eggs Missed label
            // if the go left boolean is true AND chickens left is greater than 0
            if (goleft == true && player.Left > 0)
            {
                // then we move the chicken 12 pixels to the left
                player.Left -= 12;
                //checken image will be change to the one moving left
                player.Image = Properties.Resources.start_prince;
            }
            //if the go right is true AND chickens width and left is less than form width
            // meaning the chicken is still within the frame of the game
            if (goright == true && player.Left + player.Width < this.ClientSize.Width)
            {
                // move the chicken 12 pixels to the right
                player.Left += 12;
                // change the chicken image to the one moving right
                player.Image = Properties.Resources.start_prince;
            }
            //below for loop will check the eggs dropping from the top
            // for each Control we are calling X in this form
            foreach (Control X in this.Controls)
            {
                // if X is a type of picture box AND it has the tag of Eggs
                if (X is PictureBox && (((String)X.Tag == "key") || ((String)X.Tag == "bomb")))
                {
                    // then move X towards the bottom
                    X.Top += speed;
                    // if the EGGS [X] reaches bottom of the screen
                    if (X.Top + X.Height > this.ClientSize.Height)
                    {
                        X.Top = rndY.Next(80, 300) * -1; // position the eggs to a random Y location
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width); // position the eggs to a random X location
                    }
                    // if the eggs bound with the chicken image
                    // if both picture boxes collide
                    if (X.Bounds.IntersectsWith(player.Bounds))
                    {
                        // add 1 to the score
                        //if bomb gameover
                        if ((String)X.Tag == "bomb")
                        {
                            GameTimer2.Stop(); // stop the game timer
                                               // show the message box to say game is over. 
                            MessageBox.Show("Game Over!! We lost" + "\r\n" + "Click OK to restart");
                            // once the players clicks OK we restart the game again
                            RestartGame();
                        }
                        else
                        {
                            X.Top = rndY.Next(100, 300) * -1; // position the eggs to a random Y location
                            X.Left = rndX.Next(5, this.ClientSize.Width - X.Width); // position the eggs to a random X location
                            score++;
                        }
                    }
                    // if the score is equals to or greater than 20
                    if (score >= 20)
                    {
                        speed = 16; // increase the eggs speed to 20
                    }
                }
            }
            if (score > 1)
            {
                GameTimer2.Stop();
                player1.Stop();
                this.Hide();
                Game2ToGame3 temp = new Game2ToGame3();
                temp.Show();
            }
        }

        private void KeyisUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                // if the left key is up then change the go left to false
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                // if the right key is up then change the go right to false
                goright = false;
            }
        }

        private void KeyisDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                // if the left key is pressed change the go left to true
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                // if the right key is pressed change the go right to true
                goright = true;
            }
        }

        private void RestartGame()
        {
            // check all of the controls with this loop
            // create a control called X and check it in the form components
            foreach (Control X in this.Controls)
            {
                /// if X is a picture box and it has a tag of Eggs
                if (X is PictureBox && ((String)X.Tag == "key" || (String)X.Tag == "bomb"))
                {
                    // we move it to top of the screen
                    X.Top = rndY.Next(80, 300) * -1; // give it a random y location
                    X.Left = rndX.Next(5, this.ClientSize.Width - X.Width); // give it a random x location
                }
            }
            player.Left = this.ClientSize.Width / 2; // reset the chicken to middle of the form
            player.Image = Properties.Resources.start_prince; // change the chicken picture to face left
            score = 0; // set score to 0
            speed = 8; // set speed to 8
            goleft = false; // set go left to false
            goright = false; // set go right to false
            player1.Stream = Properties.Resources.music;
            player1.PlayLooping();
            GameTimer2.Start(); // start the game timer
        }

        private void player_Click(object sender, EventArgs e)
        {

        }
    }
}
