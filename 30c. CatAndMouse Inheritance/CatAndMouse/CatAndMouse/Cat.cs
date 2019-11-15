using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Need to add this one
using System.Windows.Forms;

namespace CatAndMouse
{
    public class Cat : Animal
    {
        // constructor requires the parent form
        public Cat(Form formInstance) : base(formInstance)
        {
            // we'll add the mouse images
            AnimalImages.Images.Add(Properties.Resources.CatUp);
            AnimalImages.Images.Add(Properties.Resources.CatRight);
            AnimalImages.Images.Add(Properties.Resources.CatDown);
            AnimalImages.Images.Add(Properties.Resources.CatLeft);

            formInstance.KeyDown += new KeyEventHandler(KeyDown);
        }

        public void CatMove()
        {
            if (CanMove(currentDirection))  // we might have changed direction, but still be against a wall
            {
                this.Move(currentDirection);
            }
        }

        public void KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Right:
                    currentDirection = Direction.Right;
                    break;
                case Keys.Left:
                    currentDirection = Direction.Left;
                    break;
                case Keys.Up:
                    currentDirection = Direction.Up;
                    break;
                case Keys.Down:
                    currentDirection = Direction.Down;
                    break;
            }
            this.CatMove();
        }

    }
}
