using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAI
{
    public partial class Form1 : Form
    {
        private int xPos = 20;
        private int yPos = 20;
        private int deltaX = 1;
        private int deltaY = 1;
        const int WinWidth = 640;
        const int WinHeight = 480;
        const int boundary = 10;

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
            if (xPos + 15 > WinWidth)
                deltaX = -1;
            if (xPos - 15 < 0)
                deltaX = 1;
            if (yPos + 15 > WinHeight)
                deltaY = -1;
            if (yPos - 15 < 0)
                deltaY = 1;

            //update the position
            xPos += deltaX;
            yPos += deltaY;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Box.Location = new Point(xPos, yPos);
            while (true)
            {
                Movement();

                Box.Location = new Point(xPos, yPos);

            }
        }
    }
}
