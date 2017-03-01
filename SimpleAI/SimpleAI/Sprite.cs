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
        private PictureBox theSprite;

        public Sprite(int height, int width, int boundary, PictureBox sprite)
        {
            WinHeight = height;
            WinWidth = width;
            theBoundary = boundary;
            theSprite = sprite;
            xPos = theSprite.Location.X;
            yPos = theSprite.Location.Y;
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
        /*So evidently, the PictureBox control isn't actually created until it is added to the Form.
         * So even though this thread creates an PictureBox object and only needs to use the Control, it
         * still doesn't truely create the Control portion. :(
         */


        public void StartMoving()
        {
            
            //Form1.thisForm.Invoke(new Action(() => Form1.thisForm.Controls.Add(theSprite)));
            while (true)
            {
                Movement(theSprite);
                theSprite.Invoke(new Action(() => theSprite.Location = new Point(xPos, yPos)));
                //theSprite.Location = new Point(xPos, yPos);
                Thread.Sleep(10);

            }
        }
        
    }
}
