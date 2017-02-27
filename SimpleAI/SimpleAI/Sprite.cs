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

        private int WinHeight;
        private int WinWidth;
        private int theBoundary;

        public Sprite(int height, int width, int boundary)
        {
            WinHeight = height;
            WinWidth = width;
            theBoundary = boundary;
            
        }

       private void Movement(PictureBox theSprite)
        {
            //make sure we don't go past the screen
            if ((xPos + (theBoundary + theSprite.Width)) > WinWidth)
                deltaX = -1;
            else if ((xPos - (theBoundary + theSprite.Width)) < 0)
                deltaX = 1;
            if ((yPos + (theBoundary)) > WinHeight)
                deltaY = -1;
            else if ((yPos - (theBoundary)) < 0)
                deltaY = 1;

            //update the position
            xPos += deltaX;
            yPos += deltaY;
        }
        
        public void StartMoving(object aSprite)
        {
            PictureBox theSprite = (PictureBox)aSprite;
            while (true)
            {
                Movement(theSprite);
                theSprite.Invoke( = new Point(xPos, yPos);

                Thread.Sleep(10);

            }
        }
        
    }
}
