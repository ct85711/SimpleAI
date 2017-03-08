using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This class is an abstraction of the various movement options that the sprite can move into.
 */

namespace SimpleAI.SpriteMovement.Movement
{
    abstract class SpriteMovement : iSpriteMovement
    {
        //Establishing some basic information necessary to figure out the direction to go into
        protected int deltaX;
        protected int deltaY;

        protected int WinHeight;
        protected int WinWidth;
        protected int theBoundary;

        //constructor
        protected SpriteMovement(int height, int width, int boundary, int dX, int dY)
        {
            WinHeight = height;
            WinWidth = width;

            deltaX = dX;
            deltaY = dY;
        }

        public abstract Point movement(Point location);
    }
}
