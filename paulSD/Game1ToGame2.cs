using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paulSD
{
    public partial class Game1ToGame2 : Form
    {
        public Game1ToGame2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game2 game2 = new Game2();
            game2.Show();
            this.Hide();
        }
    }
}
