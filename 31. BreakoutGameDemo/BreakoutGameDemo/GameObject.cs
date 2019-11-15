using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BreakoutGameDemo
{
    public class GameObject
    {
        protected bool blnIsVisible;
        protected Rectangle recPosition;
        protected System.Drawing.Brush drawingBrushColour;

        public GameObject(int x, int y, int width, int height, bool blnIsVisible, Brush drawingBrushColour)
        {
            this.blnIsVisible = blnIsVisible;
            recPosition = new Rectangle(x, y, width, height);
            this.drawingBrushColour = drawingBrushColour;
        }

        public bool GetBlnIsVisible()
        {
            return blnIsVisible;
        }
        public Rectangle GetRecPosition()
        {
            return recPosition;
        }

        public Brush GetDrawingBrushColour()
        {
            return drawingBrushColour;
        }

        public void SetBlnIsVisible(bool isVisible)
        {
            blnIsVisible = isVisible;
        }

        public void SetRecPosition(Rectangle position)
        {
            recPosition = position;
        }

        public void SetDrawingBrushColour(Brush brushColour)
        {
            drawingBrushColour = brushColour;
        }

        public void MakeVisible()
        {
            blnIsVisible = true;
        }

        public void MakeInvisible()
        {
            blnIsVisible = false;
        }

        public bool CheckForIntersect(Rectangle recOther)
        {
            if (recPosition.IntersectsWith(recOther))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
