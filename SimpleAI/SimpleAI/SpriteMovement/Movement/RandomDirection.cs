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
            return base.movement(location);
        }
    }
}
