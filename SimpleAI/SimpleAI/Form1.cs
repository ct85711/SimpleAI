using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SimpleAI
{
    public partial class Form1 : Form
    {

        const int WinWidth = 640;
        const int WinHeight = 410;
        const int boundary = 15;

        private Thread movement = null;
        private Thread movement2 = null;

        private Sprite sprite1;
        private Sprite sprite2;
        public static Form thisForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //define the Delegate so that we can update the PictureBox's position
            //myDelegate = new SetImgPos(SetPosition);
            thisForm = this;
        }

        //this starts the program, by creating a new thread that will bouncing the box around
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);

            //Create the first sprite object
            PictureBox theSprite = new PictureBox();
            theSprite.Width = 20;
            theSprite.Height = 20;
            theSprite.BackColor = Color.Red;
            theSprite.Visible = true;
            Controls.Add(theSprite);

            //create the otherr sprite's object
            PictureBox theSprite2 = new PictureBox();
            theSprite2.Width = 20;
            theSprite2.Height = 20;
            theSprite2.BackColor = Color.Blue;
            theSprite2.Visible = true;
            Controls.Add(theSprite2);

            btnStop.Enabled = true;

            //create the sprite object and set it's location to an random position
            //and start it moving
            theSprite.Location = new Point(rnd.Next(50, 300), rnd.Next(50, 300));
            sprite1 = new Sprite(WinHeight, WinWidth, boundary, theSprite);
            movement = new Thread(sprite1.StartMoving);
            movement.Start();

            //wait 50 miliseconds before creating the other sprite, to help space them apart
            Thread.Sleep(50);

            //this should create a new sprite in a new random location
            //afterwards start it moving
            theSprite2.Location = new Point(rnd.Next(50, 300), rnd.Next(50, 300));
            sprite2 = new Sprite(WinHeight, WinWidth, boundary, theSprite2);
            movement2 = new Thread(sprite2.StartMoving);
            movement2.Start();

        }

        //This method, we stop the movement thread from going around
        private void btnStop_Click(object sender, EventArgs e)
        {
            movement.Abort();
            movement2.Abort();
        }
    }
}
