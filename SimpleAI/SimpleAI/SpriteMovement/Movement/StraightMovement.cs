using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAI.SpriteMovement.Movement
{
    class StraightMovement : SpriteMovement
    {
        //Constructor
        public StraightMovement(int height, int width, int boundary, int dX, int dY) : base(height, width, boundary, dX, dY)
        { }

        public override Point movement(Point location)
        {
            int xPos = location.X;
            int yPos = location.Y;
            //make sure we don't go past the screen 
            if ((xPos + theBoundary) > WinWidth)
                deltaX = -1;
            else if ((xPos - theBoundary) < 0)
                deltaX = 1;
            if ((yPos + theBoundary) > WinHeight)
                deltaY = -1;
            else if ((yPos - theBoundary) < 0)
                deltaY = 1;

            //update the position 
            xPos += deltaX;
            yPos += deltaY;

            return new Point(xPos, yPos);
        }
    }
}
