using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleAI
{
    public partial class Form1 : Form
    {
        private int xPos = 20;
        private int yPos = 20;
        const int WinWidth = 640;
        const int WinHeight = 480;
        const int boundary = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Box.Location = new Point(xPos, yPos);
            while (true)
            {
                Movement();

                Box.Location = new Point(xPos, yPos);

            }
        }

        private void Movement()
        {

        }
    }
}
