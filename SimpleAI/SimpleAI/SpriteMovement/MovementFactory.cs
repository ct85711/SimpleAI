using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleAI.SpriteMovement.Movement;

namespace SimpleAI.SpriteMovement
{
    enum MovementTypes
    {
        Straight,
        Random
    }

    class MovementFactory
    {
        private int deltaX;
        private int deltaY;

        private int WinHeight;
        private int WinWidth;
        private int theBoundary;

        //constructors
        public MovementFactory(int height, int width)
        {
            deltaX = 1;
            deltaY = 1;
            theBoundary = 10;

            WinHeight = height;
            WinWidth = width;
        }
        public MovementFactory(int height, int width, int boundary, int dX, int dY)
        {
            WinHeight = height;
            WinWidth = width;

            deltaX = dX;
            deltaY = dY;
        }

        //this method allows the user to chose which type of moveing algorithm they want to use
        public iSpriteMovement ChooseMovement(MovementTypes type)
        {
            iSpriteMovement spriteMovement;
            switch (type)
            {
                case MovementTypes.Straight:
                    spriteMovement = new StraightMovement(WinHeight, WinWidth, theBoundary, deltaX, deltaY);
                    break;
                case MovementTypes.Random:
                    spriteMovement = new RandomDirection(WinHeight, WinWidth, theBoundary, deltaX, deltaY);
                    break;
                default:
                    spriteMovement = new StraightMovement(WinHeight, WinWidth, theBoundary, deltaX, deltaY);
                    break;
            }

            return spriteMovement;
        }
    }
}
