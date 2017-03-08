using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleAI.SpriteMovement.Movement;

//I moved this enum out into the full application's namespace, to allow everyone to easily access the enum
namespace SimpleAI
{
    enum MovementTypes
    {
        Straight,
        Random
    }
}

namespace SimpleAI.SpriteMovement
{
    //This class is the factory class that creates the correct movement type that we want to use
    //by default, this class will have a default value of straight movement
    //by changing it's property method, you can choose a different one
    class MovementFactory
    {
        private int deltaX;
        private int deltaY;

        private int WinHeight;
        private int WinWidth;
        private int theBoundary;

        public MovementTypes movementType { get; set; }

        //constructors
        public MovementFactory(int height, int width)
        {
            deltaX = 1;
            deltaY = 1;
            theBoundary = 10;

            WinHeight = height;
            WinWidth = width;
            this.movementType = MovementTypes.Straight;
        }
        public MovementFactory(int height, int width, int boundary, int dX, int dY)
        {
            WinHeight = height;
            WinWidth = width;

            deltaX = dX;
            deltaY = dY;
            this.movementType = MovementTypes.Straight;
        }

        //this method allows the user to chose which type of moveing algorithm they want to use
        public iSpriteMovement ChooseMovement()
        {
            iSpriteMovement spriteMovement;
            switch (this.movementType)
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
