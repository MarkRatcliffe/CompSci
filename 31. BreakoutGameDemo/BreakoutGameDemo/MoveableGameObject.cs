using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BreakoutGameDemo
{
    public class MoveableGameObject : GameObject
    {
        private float fltSpeed;
        private float fltXVel;
        private float fltYVel;
        private bool blnIsGlued;

        public MoveableGameObject(int x, int y, 
                                  int width, int height, 
                                  bool blnIsVisible, 
                                  float fltSpeed, 
                                  float fltXVel, float fltYVel, 
                                  bool blnIsGlued, 
                                  Brush drawingBrushColour)
                                  : base(x, y, width, height, blnIsVisible, drawingBrushColour)
        {
            this.fltSpeed = fltSpeed;
            this.fltXVel = fltXVel;
            this.fltYVel = fltYVel;
            this.blnIsGlued = blnIsGlued;
        }
        public float GetFltSpeed()
        {
            return fltSpeed;
        }

        public float GetfltXVel()
        {
            return fltXVel;
        }

        public float GetfltYVel()
        {
            return fltYVel;
        }
        public bool GetBlnIsGlued()
        {
            return blnIsGlued;
        }

        public void SetFltSpeed(float speed)
        {
            fltSpeed = speed;
        }

        public void SetFltXVel(float xVel)
        {
            fltXVel = xVel;
        }

        public void SetFltYVel(float yVel)
        {
            fltYVel = yVel;
        }

        public void Glue()
        {
            blnIsGlued = true;
        }

        public void UnGlue()
        {
            blnIsGlued = false;
        }

        public void ChangePosition(int x, int y)
        {
            recPosition.Location = new Point(x, y);
        }
        public void ChangePosition(int x)
        {
            recPosition.Location = new Point(x, recPosition.Y);
        }


    }
}
