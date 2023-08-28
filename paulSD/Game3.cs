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
    public partial class Game3 : Form
    {
        SoundPlayer player = new SoundPlayer();
        public Game3()
        {
            InitializeComponent();
        }

        private void StartbuttonEvent(object sender, EventArgs e)
        {
            StartGame();
        }

        private void EnterMouseEvent(object sender, EventArgs e)
        {
            EndGame();
        }

        private void ShowScreenWindow(object sender, EventArgs e)
        {
            End end = new End();
            end.Show();
            player.Stop();
            this.Hide();
        }

        private void StartGame()
        {
            StartButton.Enabled = false;
            player.Stream = Properties.Resources.music;
            player.PlayLooping();
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Enabled = true;
                    x.MouseDown += X_MouseDown;

                    if (Tag == null)
                    {
                        x.BackColor = Color.LightBlue;
                    }
                }
            }
        }

        private void X_MouseDown(object? sender, MouseEventArgs e)
        {
            EndGame();
        }

        private void EndGame()
        {
            StartButton.Enabled = true;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    x.Enabled = false;

                    if (Tag == null)
                    {
                        x.BackColor = Color.Black;
                    }
                }
            }
        }
    }
}
