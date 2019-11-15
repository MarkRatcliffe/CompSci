using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Need to add these
using System.Windows.Forms;
using System.Media;

namespace CatAndMouse
{
    public class Mouse : Animal
    {
        // Define and initialise variables
        public int changeFrequency = 5; // increase to reduce change of direction

        // Mouse is under computer control through a timer
        private Timer timer = new Timer();
        private Random rnd = new Random();

        private Cat theEnemy;

        private SoundPlayer captureSound = new SoundPlayer(Properties.Resources.CatGrowl);

        // constructor requires the parent form
        // it also needs a handle on the cat to test for capture
        public Mouse(Form formInstance, Cat theCat): base(formInstance)
        {
            theEnemy = theCat;
            timer.Interval = 100;   // the timer will kick off Tick 10 times/second
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);

            // we'll add the mouse images
            AnimalImages.Images.Add(Properties.Resources.MouseUp);
            AnimalImages.Images.Add(Properties.Resources.MouseRight);
            AnimalImages.Images.Add(Properties.Resources.MouseDown);
            AnimalImages.Images.Add(Properties.Resources.MouseLeft);

        }

        public void MouseMove()
        {
            // let's put more of a random element in to movement
            int randomChange = rnd.Next(0, changeFrequency + 1); // gives 0 to changeFrequency
            if (randomChange == changeFrequency)
            {
                currentDirection = (Direction)rnd.Next(0, 4); // creates a value 0 to 3
            }

            // let's put more of a random element in

            if (!CanMove(currentDirection))
            {
                // if can't move in current direction, try another random direction
                currentDirection = (Direction)rnd.Next(0, 4); // creates a value 0 to 3
            }

            // Now move
            if (CanMove(currentDirection))  // we might have changed direction, but still be against a wall
            {
                this.Move(currentDirection);
            }
        }


        // timer_tick is called automatically by the Timer
        private void timer_Tick(object sender, EventArgs e)
        {
            // Keep moving the mouse
            MouseMove();
            if (this.Intersect(theEnemy))
            {
                playCaptureSound();
            }

        }

        private void playCaptureSound()
        {
            captureSound.Play();
        }
    }
}
