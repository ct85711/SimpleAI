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
        const int boundary = 10;
        Boolean continueLoop = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Movement()
        {
            //make sure we don't go past the screen
            if ((xPos + (15 + Box.Width)) > WinWidth)
                deltaX = -1;
            else if ((xPos - (15 + Box.Width)) < 0)
                deltaX = 1;
            if ((yPos + (15)) > WinHeight)
                deltaY = -1;
            else if ((yPos - (15)) < 0)
                deltaY = 1;

            //update the position
            xPos += deltaX;
            yPos += deltaY;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            Box.Location = new Point(xPos, yPos);
            while (continueLoop)
            {
                Movement();

                Box.Location = new Point(xPos, yPos);
                //Console.WriteLine("X: " + xPos + ", Y: " + yPos + ", DeltaX: " + deltaX + ", DeltaY: " + deltaY);

                Thread.Sleep(10);

            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            continueLoop = false;
            Console.WriteLine("Stop loop!");
        }
    }
}
