using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAI
{
    class Sprite
    {
        public int xPos = 20;
        public int yPos = 20;

        private int deltaX = 1;
        private int deltaY = 1;
        private PictureBox sprite;

        private int WinHeight;
        private int WinWidth;
        private int Boundary;

        public Sprite(Form theForm, int height, int width, int boundary, Color theColor)
        {
            WinHeight = height;
            WinWidth = width;
            Boundary = boundary;
            Random rnd = new Random();

            sprite = new PictureBox();
            sprite.Width = 20;
            sprite.Height = 20;
            sprite.BackColor = theColor;
            theForm.Controls.Add(sprite);
            sprite.Visible = true;
            sprite.Location = new Point(rnd.Next(50, 300), rnd.Next(50, 300));
        }

       /* private void Movement()
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
        */
    }
}
