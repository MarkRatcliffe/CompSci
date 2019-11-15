using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;               // You need this to play sounds
using OneArmedBandit.Properties;  // You need this to access Resources

namespace OneArmedBandit
{

    public partial class Form1 : Form
    {
        private Random rand = new Random(); 

        // we put all images in array, just so we can reference them by index
        private Image[] wheelImages = { Resources.apple, Resources.banana, Resources.bar, Resources.grape, Resources.orange, Resources.pair, Resources.raspberry, Resources.strawberry };

        private WheelOfFruit[] theWheels = new WheelOfFruit[3]; // This creates space for the three WheelOfFruit - does not initialise yet

        public Form1()
        {
            InitializeComponent();
        }

        private void updatePictureBoxes()
        {
            pictureBox1.Image = wheelImages[(int)theWheels[0].getCurrentFruit()];
            pictureBox2.Image = wheelImages[(int)theWheels[1].getCurrentFruit()];
            pictureBox3.Image = wheelImages[(int)theWheels[2].getCurrentFruit()];
            pictureBox1.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // This code is executed when the program starts

            for (int i=0; i< theWheels.Length; i++)
            {
                theWheels[i] = new WheelOfFruit();
            }
            playStart();
            updatePictureBoxes();  // redraw the images
        }

        private void spinButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < theWheels.Length; i++)
            {
                theWheels[i].spin(rand.Next(5,50));
            }
            updatePictureBoxes();  // redraw the images
            playStart();
        }

        private void nudgeButton1_Click(object sender, EventArgs e)
        {
            theWheels[0].spin(1);
            updatePictureBoxes();
            nudgeButton1.Enabled = false;    // this is how we disable a button
            playSpin();
        }

        private void nudgeButton2_Click(object sender, EventArgs e)
        {
            theWheels[1].spin(1);
            updatePictureBoxes();
            playSpin();
        }

        private void nudgeButton3_Click(object sender, EventArgs e)
        {
            theWheels[2].spin(1);
            updatePictureBoxes();
            playSpin();
        }

        private void playStart() // procedure to play sound in resources
        {
            SoundPlayer audio = new SoundPlayer(Resources.startSound); 
            audio.Play();
        }

        private void playSpin() // procedure to play sound in resources
        {
            SoundPlayer audio = new SoundPlayer(Resources.spinSound);
            audio.Play();
        }
    }
}
