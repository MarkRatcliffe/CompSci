using System;
using System.Collections.Generic;
using System.Text;

namespace SortedNames
{
    class Names
    {
        private string[] theNames = new string[10];
        private int nextFreeLocation = 0;

        public bool Add (string aName)
        {
            if (nextFreeLocation >= theNames.Length)
            {
                return false;  // cannot add a new name if list is full
            }

            if (nextFreeLocation == 0) // inserting at start
            {
                theNames[0] = aName;
                nextFreeLocation++;
                return true;
            }

            // now find the item and shunt 
            int position = 0;
            while ((position < nextFreeLocation ) && (aName.CompareTo(theNames[position]) > 0 ))
            {
                position++;
            }
            // we have now identified where to insert the new name
            for (int i= nextFreeLocation;  i > position; i--)
            {
                theNames[i] = theNames[i - 1]; // shunt up lower item
            }
            // finally insert pour name into the correct location
            theNames[position] = aName;
            nextFreeLocation++;  // increment for next time
            return true;
        }

        // find a name through binary chop
        // return position of name, or -1 if not found
        public int FindName(String nameToFind)
        {
            int lower = 0;
            int upper = nextFreeLocation - 1;
            int mid = 0;

            while (lower <= upper) // if lower > upper tehn didnt find it
            {
                mid = (lower + upper) / 2;
                if (theNames[mid] == nameToFind)
                    return mid; // found it so return position
                if (nameToFind.CompareTo(theNames[mid]) > 0)
                    // name is greater so we move to upper half
                    lower = mid + 1;
                else
                    // name is lower so we move to lower half
                    upper = upper - 1;
            }
            return -1; // could not find name
        }


        public void DisplayNames()
        {
            for (int i=0; i < nextFreeLocation; i++)
            {
                Console.WriteLine(theNames[i]);
            }
        }
    }
}
