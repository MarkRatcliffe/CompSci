using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRecords
{
    [Serializable]  //Set this attribute to all the classes that want to serialize
    public class Teachers
    {
        private Teacher[] contents;
        private int currentSize = 0;

        public Teachers(int maxSize)
        {
            contents = new Teacher[maxSize];
        }

        // getCurrentSize returns the current number of Teachers in the structure (1 based)
        // returns the current number of Teachers in the structure (1 based)
        public int GetCurrentSize()
        {
            return currentSize;
        }


        // AddTeacher adds an existing teacher to the collection, if there is space
        // returns -1 if insufficient space, 0 otherwise
        public int AddTeacher(ref Teacher theTeacher)
        {
            if (currentSize < contents.Length)
            {
                contents[currentSize] = theTeacher;
                currentSize++;
                return 0;
            }
            else
            {
                return -1;
            }
        }

        //GetTeacher gets an existing teacher by name (0 based)
        //returns nothing if not found
        public Teacher GetTeacher(String theFirstName, String theLastName)
        {
            for (int i = 0; i < currentSize; i++)
            {
                if ((contents[i].GetFirstName() == theFirstName) && (contents[i].GetLastName() == theLastName))
                        return contents[i];
            }
            return null;
        }

        // RemoveTeacher removes an existing Teacher by name if found
        // returns -1 if not found
        public int RemoveTeacher(String theFirstName, String theLastName)
        {
            // first locate the subject
            for (int i = 0; i < currentSize; i++)
            {
                if ((contents[i].GetFirstName() == theFirstName) && (contents[i].GetLastName() == theLastName))
                {
                    // we've found the Student
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

        //redefine the ToString which defines how Students will be displayed
        public override String ToString()
        {
            String tempString = "";
            for (int i = 0; i < currentSize - 1; i++)
            {
                tempString = tempString + contents[i].ToString();
            }
            tempString = tempString + Environment.NewLine;

            return tempString;
        }
    }
}
