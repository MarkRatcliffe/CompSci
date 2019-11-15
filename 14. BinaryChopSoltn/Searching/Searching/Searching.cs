using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    class Searching
    {
        public int serialSearch(String[] theList, String itemToSearchFor)
        {
            // check if the array is empty, if so return an error
            if (theList.Length == 0)
            {
                return -1;  // we'll use this as an error code
            }

            // Use a for loop, initialise counter = 0 (first position/index in array)  
            // set the number of iterations the same as the last position/index of the array 
            // (so to that each location in the array can be checked)

            int counter;    // counter defined outside loop, so I can use it later

            for (counter = 0; counter < theList.Length; counter++)
            {
                // check if item (at current position) is equal to item searched
                // if item found return the position/index (the value of the counter)
                if (itemToSearchFor == theList[counter])
                {
                    return counter;
                }
            }

            // If we get here, them item is still not found, return -1
            return -1; 
        }

        public int binarySearch(String[] theList, String itemToSearchFor)
        {
            int min = 0;                   // the start of the array
            int max = theList.Length - 1;  // the end of the array
            int mid;
            while (min <= max)
            {
                mid = (min + max) / 2;
                if (itemToSearchFor == theList[mid])
                {
                    return mid;
                }
                else if (itemToSearchFor.CompareTo(theList[mid]) < 0)   // found the item
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;   // if we get here, we haven't found it, so return -1


        }

    }
}
