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

        private Sprite sprite1;
        //  private Sprite sprite2;
        public static Form thisForm;

        public delegate void AccControlDelegate(Control aControl);

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
            btnStop.Enabled = true;
            sprite1 = new Sprite(WinHeight, WinWidth, boundary);

            movement = new Thread(sprite1.StartMoving);
            movement.Start();

        }
        
        //This method, we stop the movement thread from going around
        private void btnStop_Click(object sender, EventArgs e)
        {
            movement.Abort();
        }
    }
}
