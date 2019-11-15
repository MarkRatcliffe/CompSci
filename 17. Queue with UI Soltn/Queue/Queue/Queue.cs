using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueExample
{
    public class Queue
    {
        private Object[] theItems;
        private int front = 0;                  // position of start of Queue
        private int back = 0;                   // position of back of Queue
        private int maxSize = 10;               // maximum capacity of Queue
        private int length = 0;                 // number of items currently in Queue

        public Queue(int theSize)
        {
            maxSize = theSize;
            theItems = new Object[theSize];
        }

        public void Add(Object theObject)        // add to back

        {
            if (length < maxSize)
            {
                theItems[back] = theObject;      // back always points to next location to use
                back = (back + 1) % maxSize;
                length++;
            }
        }

        public Object Remove()                    // remove from front
        {
            Object temp = null;
            if (length > 0)
            {
                temp = theItems[front];           // front always points to the location of the front
                front = (front + 1) % maxSize;    // move front along
                length--;
            }
            return temp;                          // initially set to null unless reset in if
        }

        public int Length()
        {
            return length;
        }

        public bool IsEmpty()
        {
            return (this.length == 0);
        }

        public override String ToString()
        {
            String temp = "front ->\t";
            int tempPos = front;         // a temporary pointer that passes along the Queue
            for (int i = 0; i < length; i++)
            {
                temp = temp + theItems[tempPos] + Environment.NewLine  + "\t";
                // when we get to the end, we go back to the beginning 
                tempPos = (tempPos + 1) % maxSize;
            }
            temp = temp + "\t <- back";
            return temp;
        }
    }
}
