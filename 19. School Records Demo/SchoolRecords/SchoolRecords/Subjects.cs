using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// author Mark Ratcliffe
namespace SchoolRecords
{
    public class Subjects
    {

        public const int maxSize = 6;
        private Subject[] contents;
        private int currentSize = 0;

        public Subjects()
        {
            contents = new Subject[maxSize];
        }

        // getCurrentSize returns the current number of items in the structure (1 based)
        // returns the current number of items in the structure (1 based)
        public int getCurrentSize()
        {
            return -1;
        }


        // addSubject adds an existing subject to the collection, if there is space
        // returns -1 if insufficient space, 0 otherwise
        public int addSubject(ref Subject theSubject)
        {
            return -1;
        }

        // getSubject gets an existing subject by position if index is valid
        // returns nothing if not found
        public Subject getSubject(int position)
        {
            return null;
        }

        //getSubject gets an existing subject by name and level if found (0 based)
        //returns nothing if not found
        public Subject getSubject(String theName, String theLevel)
        {
            return null;
        }

        //removeSubject removes an existing subject by name and level if not found
        // returns -1 if not found
        public int removeSubject(String theName, String theLevel)
        {
            return -1;
        }


        //redefine the ToString which defines how Subjects will be displayed
        public override String ToString()
        {
            String tempString = "Subjects: ";
            for (int i = 0; i < currentSize - 1; i++)
            {
                tempString = tempString + contents[i].ToString();
            }
            tempString = tempString + Environment.NewLine;

            return tempString;
        }
    }
}
