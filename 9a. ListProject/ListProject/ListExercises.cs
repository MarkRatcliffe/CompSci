using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    class ListExercises
    {
        private string[] names = new string[10];
        private int nextFreeLocation = 0;

        // addName takes in a name, adds it to the list maintaining the order
        // passes back an integer (-1 if error), giving inserted location
        public int AddNameToList(string theName)
        {
            /* 0) if nextFreeLocation > names.length return –1 as there is no room for entries 

                1) Locate position(position) to insert the new value (theName) to maintain ordered list 
                   You can use a while loop to move through array while (theName > names[position])
                2) "Shunting"  Use a loop (i) to go from nextFreeLocation down to position 
                    names[i] = names[i - 1]
                3) Insert theName into position in array     names[position] = theName 
                4) increment nextFreeLocation for next time 
                5) return position as you leave function 
            */

            // first check if there is space - step 0 from above
            if (nextFreeLocation > names.Length)   
                return -1;

            // now locate position to insert new name - step 1 from above
            int position = 0;       
            // while (theName > names[position])   // cannot do this in C# 
            while ((position < nextFreeLocation) &&
                   (theName.CompareTo(names[position]) > 0))
            {
                position = position + 1;
            }
           
            // now do shunting - step 2 above
            for (int i = nextFreeLocation; i > position; i++)
            {
                names[i] = names[i - 1];
            }

            // now insert theName into position - step 3 above
            names[position] = theName;

            // increment nextFreeLocation for next time - step 4 above
            nextFreeLocation++;

            // pass back the position we inserted theName
            return position;
        }

        // FindPositionOfName locates a name in the list
        // passes back an integer (-1 if error), giving inserted location
        public int FindPositionOfName(string theName)
        {
            // not yet implemented
            return -1;
        }

        // RemoveByPosition(int position)
        // Before you code this, break down into a series of algorithm steps
        // Do it on paper first
        public bool RemoveByPosition(int position)
        {
            // not yet implemented
            return false;
        }

        // GetListAsString just returns a formatted string of List
        public String GetListAsString()
        {
            string temp = "";



             for (int i = 0; i < nextFreeLocation; i++)
            {
                temp = temp + names[i] + "\n";
            }

            return temp;
        }
    }
}
