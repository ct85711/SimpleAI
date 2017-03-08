using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class is an abstraction of the various movement options that the sprite can move into.
 */

namespace SimpleAI.SpriteMovement
{
    abstract class Movement : iSpriteMovement
    {
        //Establishing some basic information necessary to figure out the direction to go into
        private int deltaX;
        private int deltaY;

        private int WinHeight;
        private int WinWidth;

        //constructors
        public Movement(int height, int width)
        {
            deltaX = 1;
            deltaY = 1;

            WinHeight = height;
            WinWidth = width;
        }

        public Movement(int height, int width, int dX, int dY)
        {
            WinHeight = height;
            WinWidth = width;

            deltaX = dX;
            deltaY = dY;
        }

        public abstract Point movement(Point location);
    }
}
