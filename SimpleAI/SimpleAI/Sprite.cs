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

            //Pick direction the box will go in
            PickDirection();
        }

        private void PickDirection()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int number = rnd.Next(1, 4);

            switch (number)
            {
                case 1:
                    deltaX = 1;
                    deltaY = -1;
                    break;
                case 2:
                    deltaX = -1;
                    deltaY = 1;
                    break;
                case 3:
                    deltaX = -1;
                    deltaY = -1;
                    break;
                case 4:
                    deltaX = 1;
                    deltaY = 1;
                    break;
                default:
                    break;
            }
        }

       private void Movement(PictureBox theSprite)
        {
            
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
