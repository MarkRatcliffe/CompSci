using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PicBoxExperiments
{
    public partial class Form1 : Form
    {
        public PictureBox launch;

        public Star twinkle = new Star();

        private Timer timer = new Timer();
        private int maxScreenX;
        private int maxScreenY;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // start by creating the launch button
            timer.Tick += new EventHandler(onTick);
            timer.Interval = 100;
            timer.Start();
            this.Paint += new PaintEventHandler(onPaint);


            launch = new PictureBox();
            launch.Visible = true;
            launch.MouseClick += new MouseEventHandler(onMouseClick);

            // Draw Rocket in middle of screen
            maxScreenX = this.Width - 50;  // adjustments removing border
            maxScreenY = this.Height - 80;
            launch.Bounds = new Rectangle(maxScreenX / 2, maxScreenY / 2, 20, 60);
            launch.BackColor = System.Drawing.Color.Red;

            // set star in centre of upper half of screen 
            twinkle.SetPosition(maxScreenX / 2, maxScreenY / 8);

            // add the picture box to the form
            this.Controls.Add(launch);
            launch.BringToFront();
        }

        // onPaint is called automatically (if form requires an update) but is forced by the Refresh call 
        // onPaint is responsible for all the drawing on the Graphics 
        private void onPaint(object sender, PaintEventArgs e)
        {
            twinkle.SetVisibility(true);
            twinkle.SetPosition((twinkle.GetX() + 10) % maxScreenX, twinkle.GetY());
            twinkle.Draw(e.Graphics);
    }

        // onMouseClick the star is rotated
        private void onMouseClick(object sender, MouseEventArgs e)
        {
            twinkle.Rotate();
        }

        private void onTick(object sender, EventArgs e)
        {
            // Now we update the display
            this.Refresh();
        }
    }
}
