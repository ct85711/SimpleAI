using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SimpleAI
{
    public partial class Form1 : Form
    {
        
        const int WinWidth = 640;
        const int WinHeight = 410;
        const int boundary = 15;

        private Thread movement;

        private Sprite sprite1;
        private Sprite sprite2;

        //define the delegate that we are using
        //public delegate void SetImgPos();
        //public SetImgPos myDelegate;
        //public Point location;

        //update the position
        /*public void SetPosition()
        {
            Box.Location = location;
        }
        */

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //define the Delegate so that we can update the PictureBox's position
            //myDelegate = new SetImgPos(SetPosition);
        }

        

        //this starts the program, by creating a new thread that will bouncing the box around
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;

            //Start the thread controlling the PictureBox movement
            //Box.Location = new Point(xPos, yPos);
            //movement = new Thread(StartMoving);
            // movement.Start();

            sprite1 = new Sprite(this, WinHeight, WinWidth, boundary, Color.Red);

            this.Refresh();
        }

        //This method is where we cause the PictureBox to bounce around on the screen
        

        //This method, we stop the movement thread from going around
        private void btnStop_Click(object sender, EventArgs e)
        {
            //movement.Abort();
        }
    }
}
