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
    public class Animal
    {
        // Define and initialise variables
        // New concept - protected is like private but is accessible to derived types (subclasses)
        protected Direction currentDirection = Direction.Up;
        protected PictureBox AnimalPicBox = new PictureBox();
        protected Form FormInstance;

        // I'll use this later for different mouse directions
        protected ImageList AnimalImages = new ImageList();

        // constructor requires the parent form
        public Animal(Form theForm)
        {
            FormInstance = theForm;

            // start with animal in the centre of the screen
            AnimalPicBox.Location = new System.Drawing.Point(FormInstance.ClientSize.Width / 2,
                                                            FormInstance.ClientSize.Height / 2);

            AnimalPicBox.SizeMode = PictureBoxSizeMode.AutoSize;

            FormInstance.Controls.Add(AnimalPicBox);
            AnimalPicBox.BringToFront();
        }

        // CanMove just detects to see whether a move can be made without going off the screen
        protected bool CanMove(Direction d)
        { //if we are able to move in that direction
            switch (d)
            {
                case Direction.Up:
                    return AnimalPicBox.Top >= 0;
                case Direction.Down:
                    return AnimalPicBox.Bottom > 0;
                case Direction.Left:
                    return AnimalPicBox.Right > 0;
                case Direction.Right:
                    return AnimalPicBox.Left >= 0;
                default:
                    return false;
            }
        }

        // Move moves the animal in the appropriate direction by the size of the animal
        // But the constrain means it wont move off the form - thank you Alex
        protected void Move(Direction direction)
        {

            // Change the animal image to match the new direction
            AnimalPicBox.Image = AnimalImages.Images[(int)currentDirection];

            switch (direction)
            {
                // Coordinate system has top left as origin
                //values must be constrained to edge of screen, to avoid going over them
                case Direction.Up:
                    AnimalPicBox.Top = Utils.constrain(AnimalPicBox.Top - AnimalPicBox.Height, 
                                                      0, 
                                                      FormInstance.ClientSize.Height - AnimalPicBox.Height);
                    break;
                case Direction.Right:
                    AnimalPicBox.Left = Utils.constrain(AnimalPicBox.Left + AnimalPicBox.Width, 
                                                       0, 
                                                       FormInstance.ClientSize.Width - AnimalPicBox.Width);
                    break;
                case Direction.Down:
                    AnimalPicBox.Top = Utils.constrain(AnimalPicBox.Top + AnimalPicBox.Height,
                                                      0,
                                                      FormInstance.ClientSize.Height - AnimalPicBox.Height);
                    break;
                case Direction.Left:
                    AnimalPicBox.Left = Utils.constrain(AnimalPicBox.Left - AnimalPicBox.Width, 
                                                       0,
                                                       FormInstance.ClientSize.Width - AnimalPicBox.Width);
                    break;
            }
        }

        // Intersect tests to see if this animal has banged into another. 
        // This simpest version just looks at the rectanges of the picture boxes intersecting.
        // If you are using a not rectangualr image you might want to be a little more clever.

        protected bool Intersect(Animal other)
        {
            // I now have access to two animals - this(the object itself which is an animal) and other
            return (this.AnimalPicBox.Bounds.IntersectsWith(other.AnimalPicBox.Bounds));
        }

    }
}
