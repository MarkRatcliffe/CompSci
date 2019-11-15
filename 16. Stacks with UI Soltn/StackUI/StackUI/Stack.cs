using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUI
{
    public class Stack
    {
        private Object[] theItems;
        private int top = 0;
        private int maxSize = 0;

        public Stack (int theSize)
        {
            maxSize = theSize;
            theItems = new Object[theSize];
        }

        public void Push(Object theObject)
        {
            // top always points to where we will add next item
            if (top < maxSize)    // we can only add while we have space
            {
                theItems[top] = theObject;
                top++;
            }
        }

        public Object Pop ()
        {
            if (top > 0)         // we can only remove while there are values in Stack
            {
                top--;
                Object temp = theItems[top];
                return temp;
            }
            else
                return null;
        }

        public int Depth()
        {
            return top;
        }

        public bool IsEmpty()
        {
            return (top == 0);
        }

        public override String ToString()
        {
            String temp = "";
            for (int i = top-1; i >= 0; i--)
            {
                // Note we want the first item added to be at the bottom of the stack, 
                // so we reverse loop
                temp = temp + theItems[i] + Environment.NewLine;
            }
            return temp;
        }

    }
}
