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
        private int xPos = 20;
        private int yPos = 20;
        private int deltaX = 1;
        private int deltaY = 1;
        const int WinWidth = 640;
        const int WinHeight = 410;
        const int boundary = 15;
        public Point location;
        private Thread movement;

        public delegate void SetImgPos();
        public SetImgPos myDelegate;
        public void SetPosition()
        {
            Box.Location = location;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myDelegate = new SetImgPos(SetPosition);
        }

        private void Movement()
        {
            //make sure we don't go past the screen
            if ((xPos + (boundary + Box.Width)) > WinWidth)
                deltaX = -1;
            else if ((xPos - (boundary + Box.Width)) < 0)
                deltaX = 1;
            if ((yPos + (boundary)) > WinHeight)
                deltaY = -1;
            else if ((yPos - (boundary)) < 0)
                deltaY = 1;

            //update the position
            xPos += deltaX;
            yPos += deltaY;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;

            Box.Location = new Point(xPos, yPos);
            movement = new Thread(StartMoving);
           movement.Start();
            
            //Box.Visible = false;
            this.Refresh();

        }

        
        private void StartMoving()
        {

           while (true)
            {
                Movement();
                location = new Point(xPos, yPos);
                Box.Invoke(myDelegate);
                //Console.WriteLine("X: " + xPos + ", Y: " + yPos + ", DeltaX: " + deltaX + ", DeltaY: " + deltaY);

                Thread.Sleep(10);

            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            movement.Abort();
            Console.WriteLine("Stop loop!");
            //Box.Visible = true;
        }
    }
}
