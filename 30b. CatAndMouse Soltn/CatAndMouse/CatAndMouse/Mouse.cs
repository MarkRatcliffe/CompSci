using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Need to add this one
using System.Windows.Forms;

namespace CatAndMouse
{
    public enum Direction { Up, Right, Down, Left }
    public class Mouse
    {
        // Define and initialise variables
        public Direction currentDirection = Direction.Up;
        public PictureBox MouseImage = new PictureBox();
        public int mouseSize = 25;
        public int changeFrequency = 5; // increase to reduce change of direction

        public int maxScreenX;
        public int maxScreenY;

        // I'll use this later for different mouse directions
        private ImageList MouseImages = new ImageList();

        private Timer timer = new Timer();
        private Random rnd = new Random();

        // constructor requires the parent form
        public Mouse(Form formInstance)
        {
            maxScreenX = formInstance.Width - 50;  // adjustments removing border
            maxScreenY = formInstance.Height - 80;
            timer.Interval = 100;   // the timer will kick off Tick 10 times/second
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);

            // start with mouse in the centre of the screen
            MouseImage.Location = new System.Drawing.Point(maxScreenX / 2, maxScreenY / 2);

            // we'll add the mouse images
            MouseImages.Images.Add(Properties.Resources.MouseUp);
            MouseImages.Images.Add(Properties.Resources.MouseRight);
            MouseImages.Images.Add(Properties.Resources.MouseDown);
            MouseImages.Images.Add(Properties.Resources.MouseLeft);

            formInstance.Controls.Add(MouseImage);
            MouseImage.BringToFront();
        }

        public void MoveMouse()
        {

            // let's put more of a random element in to movement
            int randomChange = rnd.Next(0, changeFrequency + 1); // gives 0 to changeFrequency
            if (randomChange == changeFrequency)
            {
                currentDirection = (Direction)rnd.Next(0, 4); // creates a value 0 to 3
            }

            bool canMove = CheckCanMoveInDirection();

            // let's put more of a random element in

            if (!canMove)
            {
                // if can't move in current direction, try another random direction
                currentDirection = (Direction)rnd.Next(0, 4); // creates a value 0 to 3

                // need to check again that we are not in a corner ie we cam actually move
                canMove = CheckCanMoveInDirection();

            }

            // Change the mouse image to match the new direction
            MouseImage.Image = MouseImages.Images[(int)currentDirection];

            if (canMove)
            {
                switch (currentDirection)
                {
                    // Coordinate system has top left as origin
                    case Direction.Up:
                        MouseImage.Top -= mouseSize;
                        break;
                    case Direction.Right:
                        MouseImage.Left += mouseSize;
                        break;
                    case Direction.Down:
                        MouseImage.Top += mouseSize;
                        break;
                    case Direction.Left:
                        MouseImage.Left -= mouseSize;
                        break;
                }
            }
        }

        public bool CheckCanMoveInDirection()
        {
            // we calculate the midpoint of mouse

            int mouseRadius = mouseSize / 2;
            int midPointX = MouseImage.Left + mouseRadius;
            int midPointY = MouseImage.Top + mouseRadius;

        
            switch (currentDirection)
            {
                // Coordinate system has top left as origin

                case Direction.Up:
                    if (midPointY - mouseSize > 0)
                        return true;
                    break;
                case Direction.Right:
                    if (midPointX - mouseSize < maxScreenX)
                        return true;
                    break;
                case Direction.Down:
                    if (midPointY - mouseSize < maxScreenY)
                        return true;
                    break;
                case Direction.Left:
                    if (midPointX - mouseSize > 0)
                        return true;
                    break;
            }
            return false;  // cannot move
        }

        // timer_tick is called automatically by the Timer
        private void timer_Tick(object sender, EventArgs e)
        {
            // Keep moving the mouse
            MoveMouse();
        }
    }
}
