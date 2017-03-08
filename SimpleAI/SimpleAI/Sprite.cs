using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleAI.SpriteMovement;

namespace SimpleAI
{
    class Sprite
    {

        private PictureBox theSprite;
        private iSpriteMovement theMovement;

        public Sprite(int height, int width, int boundary, PictureBox sprite)
        {
            MovementFactory factory = new MovementFactory(height, width, boundary, 1, 1);
            theMovement = factory.ChooseMovement();
            theSprite = sprite;
        }
        public Sprite(int height, int width, int boundary, PictureBox sprite, MovementTypes moveType)
        {
            MovementFactory factory = new MovementFactory(height, width, boundary, 1, 1);
            factory.movementType = moveType;
            theMovement = factory.ChooseMovement();
            theSprite = sprite;
        }

        public void StartMoving()
        {
            Point newPosition = theSprite.Location;

            while (true)
            {
                newPosition = theMovement.movement(newPosition);
                theSprite.Invoke(new Action(() => theSprite.Location = newPosition));
                Thread.Sleep(10);

            }
        }

    }
}
