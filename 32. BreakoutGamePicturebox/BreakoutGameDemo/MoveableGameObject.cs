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
    public class MoveableGameObject : GameObject
    {
        private float speed;
        private float xVelocity;
        private float yVelocity;
        private bool glued;

        // Constructor used to initialise a GameObject, adjusting the visbility as defined
        // The constructor includes the form to which it is to be attached.
        public MoveableGameObject(Form formInstance,
                                  int x, int y, 
                                  int width, int height, 
                                  bool visible, 
                                  float theSpeed, 
                                  float xVel, float yVel, 
                                  bool isGlued, 
                                  System.Drawing.Color fillColour)
                                  : base(formInstance, 
                                         x, y, 
                                         width, height, 
                                         visible, 
                                         fillColour)
        {
            speed = theSpeed;
            xVelocity = xVel;
            yVelocity = yVel;
            glued = isGlued;
        }

        public void SetSpeed(float theSpeed)
        {
            this.speed = theSpeed;
        }

        public float GetSpeed()
        {
            return speed;
        }

        public void SetXVelocity(float theXVel)
        {
            xVelocity = theXVel;
        }

        public float GetXVelocity()
        {
            return xVelocity;
        }


        public void SetYVelocity(float theYVel)
        {
            yVelocity = theYVel;
        }

        public float GetYVelocity()
        {
            return yVelocity;
        }


        public bool IsGlued()
        {
            return glued;
        }


        public void Glue()
        {
            glued = true;
        }

        public void UnGlue()
        {
            glued = false;
        }

        public void ChangePosition(int x, int y)
        {
            picBox.Location = new Point(x, y);
        }

        public void ChangePosition(int x)
        {
            picBox.Location = new Point(x, picBox.Location.Y);
        }
    }
}
