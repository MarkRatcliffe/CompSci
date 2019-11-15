using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRecords
{
    [Serializable]  //Set this attribute to all the classes that want to serialize
    public class Subjects
    {

        private int maxSize;
        private Subject[] contents;
        private int currentSize = 0;

        public Subjects(int maxNum)
        {
            maxSize = maxNum;
            contents = new Subject[maxNum];
        }

        // GetCurrentSize returns the current number of items in the structure (1 based)
        // returns the current number of items in the structure (1 based)
        public int GetCurrentSize()
        {
            return currentSize;
        }


        // AddSubject adds an existing subject to the collection, if there is space
        // returns -1 if insufficient space, 0 otherwise
        public int AddSubject(Subject theSubject)
        {
            if (currentSize < maxSize)
            {
                contents[currentSize] = theSubject;
                currentSize++;
                return 0;
            }
            else
            {
                return -1;
            }
        }

        // GetSubject gets an existing subject by position if index is valid
        // Note - this is a zero based structure. First is zero
        // returns nothing if not found
        public Subject GetSubject(int position)
        {
            if ((position < 0) | (position >= currentSize))
            {
                return null;  // invalid index
            }
            else
            {
                return contents[position];
            }
        }

        //GetSubject gets an existing subject by name and level if not found (0 based)
        //returns nothing if not found
        public Subject GetSubject(String theName, String theLevel)
        {
            for (int i=0; i < currentSize; i++)
            {
                if ((contents[i].GetName() == theName) & (contents[i].GetLevel() == theLevel))
                    return contents[i];
            }
            return null;
        }

        //RemoveSubject removes an existing subject by name and level if not found
        // returns -1 if not found
        public int RemoveSubject(String theName, String theLevel)
        {
            // first locate the subject
            for (int i = 0; i < currentSize; i++)
            {
                if ((contents[i].GetName() == theName) & (contents[i].GetLevel() == theLevel))
                {
                    // we've found the subject
                    // replace it from the one at the upper end of the array 
                    contents[i] = contents[currentSize - 1];
                    //delete the original at the upper end
                    contents[currentSize - 1] = null;
                    // reduce currentSize by 1
                    currentSize--;
                    // leave function with success
                    return 0;
                }
            }
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
