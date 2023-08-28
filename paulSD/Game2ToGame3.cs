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
    public partial class Game2ToGame3 : Form
    {
        public Game2ToGame3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game3 game3 = new Game3();
            game3.Show();
            this.Hide();
        }
    }
}
