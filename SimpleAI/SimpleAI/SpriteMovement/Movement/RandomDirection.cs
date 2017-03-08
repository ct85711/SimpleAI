using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class is an extension of the straight movement in that it will randomly mvoe in a different direction every so often
namespace SimpleAI.SpriteMovement.Movement
{
    class RandomDirection : StraightMovement
    {
        //TODO: make the delayAmount configurable, so we can have a different amount of delay than a hard coded 200

        //Note: Having a delay amount too small causes it to pick a new direction too often
        private int directionDelayAmount = 200;
        private int delayCounter = 0;
        //Constructor
        public RandomDirection(int height, int width, int boundary, int dX, int dY) : base(height, width, boundary, dX, dY)
        { }

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

        public override Point movement(Point location)
        {
            if (++delayCounter == directionDelayAmount)
            {
                delayCounter = 0;
                PickDirection();
            }
            return base.movement(location);
        }
    }
}
