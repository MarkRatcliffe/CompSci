using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

// Need to add this one
using System.Windows.Forms;

namespace BreakoutGameDemo
{
    public class GameObject
    {
        // pixBox is protected to allow it to be changed by derived classes
        protected PictureBox picBox;
        protected bool visibility;  // used to indicate whether an object is visible

        // Constructor used to initialise a GameObject, adjusting the visbility as defined
        // The constructor includes the form to which it is to be attached.
        public GameObject(Form theinstance,
                          int x, int y, 
                          int width, int height, 
                          bool visible, 
                          System.Drawing.Color fillColour)
        {
            picBox = new PictureBox();
            visibility = visible;
            picBox.Visible = visible;  // we also set the visibility attribute of the PictureBox
            picBox.Bounds = new Rectangle (x, y, width, height);
            picBox.BackColor = fillColour;

            // add the picture box to the form
            theinstance.Controls.Add(picBox);
            // picBox.BringToFront();
        }

        // IsVisible passes back a boolean to indicate state of visibility of PictureBox
        public bool IsVisible()
        {
            return visibility;
        }

        // GetPosition returns the rectangle for the PictureBox which includes coordinates
        public Rectangle GetPosition()
        {
            return picBox.Bounds;
        }

        // SetPosition updates rectangle of the PictureBox with new, changing its position
        public void SetPosition(Rectangle position)
        {
            picBox.Bounds = position;
        }

        // GetColour passes back the fill colour of the PictureBox
        public System.Drawing.Color GetColour()
        {
            return picBox.BackColor;
        }

        // SetColour updates the fill colour of the PictureBox
        public void SetColour(System.Drawing.Color fillColour)
        {
            picBox.BackColor = fillColour;
        }

        // SetVisibility updates the visibility of a PictureBox to on or off
        public void SetVisibility(bool isVisible)
        {
            visibility = isVisible;        // set our attribute 
            picBox.Visible = isVisible;    // and change PictureBox too 
        }


        // CheckForIntersect returns true if the two PictureBoxes overlap
        public bool CheckForIntersect(GameObject other)
        {
            return (picBox.Bounds.IntersectsWith(other.picBox.Bounds));
        }

    }
}
