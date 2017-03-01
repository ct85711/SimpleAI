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
            Random rnd = new Random();

            PictureBox theSprite = new PictureBox();
            theSprite.Width = 20;
            theSprite.Height = 20;
            theSprite.BackColor = Color.Red;
            theSprite.Visible = true;
            theSprite.Location = new Point(rnd.Next(50, 300), rnd.Next(50, 300));
            Controls.Add(theSprite);

            
            PictureBox theSprite2 = new PictureBox();
            theSprite2.Width = 20;
            theSprite2.Height = 20;
            theSprite2.BackColor = Color.Blue;
            theSprite2.Visible = true;
            theSprite2.Location = new Point(rnd.Next(50, 300), rnd.Next(50, 300));
            Controls.Add(theSprite2);

            btnStop.Enabled = true;
            sprite1 = new Sprite(WinHeight, WinWidth, boundary,theSprite);
            sprite2 = new Sprite(WinHeight, WinWidth, boundary, theSprite2);

            movement = new Thread(sprite1.StartMoving);
            movement2 = new Thread(sprite2.StartMoving);
            movement.Start();
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
