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
        private DateTime timeStarted;


        public Player()
        {

            InitializeComponent();
            xCoord = 0;
            yCoord = 0;
           
        }

        private void Player_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timeStarted = DateTime.Now;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (DateTime.Now - timeStarted).Milliseconds.ToString();
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

              //////////////////////////////////////////
              if (e.KeyCode == Keys.Up)
              {
                  yCoord -= 50;
                  Location = new Point(xCoord, yCoord);

              }
              if (e.KeyCode == Keys.Left)
              {
                  xCoord -= 50;
                  Location = new Point(xCoord, yCoord);
              }
              if (e.KeyCode == Keys.Down)
              {
                  yCoord += 50;
                  Location = new Point(xCoord, yCoord);
              }
              if (e.KeyCode == Keys.Right)
              {
                  xCoord += 50;
                  Location = new Point(xCoord, yCoord);
              } 
          }




    }
}
