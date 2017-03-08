using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAI.SpriteMovement
{
    class StraightMovement : Movement
    {
        public StraightMovement(int height, int width) : base(height,width)
        {

        }

        public StraightMovement(int height, int width, int dX, int dY) : base(height, width, dX, dY)
        {

        }

        public override Point movement(Point location)
        {
            throw new NotImplementedException();
        }
    }
}
