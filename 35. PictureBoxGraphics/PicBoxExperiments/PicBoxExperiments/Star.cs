using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;  // add in this so I can use Point

namespace PicBoxExperiments
{
    public class Star
    {
        private Point position;
        private bool visible;
        private Image theImage;

        private MbrUtils MyUtils = new MbrUtils();

        public Star()
        {
            theImage = Properties.Resources.star;
        }

        public void SetPosition (int x, int y)
        {
            position = new Point(x, y);
        }

        public int GetX()
        {
            return position.X;
        }

        public int GetY()
        {
            return position.Y;
        }

        public bool GetVisibility()
        {
            return visible;
        }

        public void SetVisibility(bool theValue)
        {
            visible = theValue;
        }

        public void Rotate()
        {
            theImage = MyUtils.RotateImage(theImage, 90);
        }

        public void Draw(Graphics theGraphics)
        {
            if (visible)
            {
                theGraphics.DrawImage(theImage, position);
            }
        }

    }
}
