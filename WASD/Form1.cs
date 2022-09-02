using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WASD
{
    public partial class Player : Form
    {
        private int xCoord;
        private int yCoord;
        public Player()
        {
            InitializeComponent();
            xCoord = 0;
            yCoord = 0;
        }

        private void Player_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                yCoord -= 50;
                Location = new Point(xCoord, yCoord);
                
            }
            if (e.KeyCode == Keys.A)
            {
                xCoord -= 50;
                Location = new Point(xCoord, yCoord);
            }
            if (e.KeyCode == Keys.S)
            {
                yCoord += 50;
                Location = new Point(xCoord, yCoord);
            }
            if (e.KeyCode == Keys.D)
            {
                xCoord += 50;
                Location = new Point(xCoord, yCoord);
            }
        }

       
    }
}
