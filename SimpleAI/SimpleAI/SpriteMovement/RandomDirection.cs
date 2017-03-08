using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class is an extension of the straight movement in that it will randomly mvoe in a different direction every so often
namespace SimpleAI.SpriteMovement
{
    class RandomDirection : StraightMovement
    {
        //Constructors
        public RandomDirection(int height, int width) : base(height,width)
        {

        }

        public RandomDirection(int height, int width, int dX, int dY) : base(height, width, dX, dY)
        {

        }

        public override Point movement(Point location)
        {
            throw new NotImplementedException();
        }
    }
}
