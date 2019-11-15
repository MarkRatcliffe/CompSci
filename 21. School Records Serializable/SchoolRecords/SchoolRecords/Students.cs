using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolRecords
{
    [Serializable]  //Set this attribute to all the classes that want to serialize
    public class Students
    {
        private Student[] contents;
        private int currentSize = 0;

        public Students(int maxSize)
        {
            contents = new Student[maxSize];
        }

        // GetCurrentSize returns the current number of Students in the structure (1 based)
        // returns the current number of students in the structure (1 based)
        public int GetCurrentSize()
        {
            return currentSize;
        }


        // AddStudent adds an existing student to the collection, if there is space
        // returns -1 if insufficient space, 0 otherwise
        public int AddStudent(Student theStudent)
        {
            if (currentSize < contents.Length)
            {
                contents[currentSize] = theStudent;
                currentSize++;
                return 0;
            }
            else
            {
                return -1;
            }
        }

        // GetStudent gets an existing student by position if index is valid
        // Note - this is a zero based structure. First is zero
        // returns nothing if not found
        public Student GetStudent(int position)
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


        //GetStudent gets an existing student by names (0 based)
        //returns nothing if not found
        public Student GetStudent(String theFirstName, String theLastName)
        {
            for (int i = 0; i < currentSize; i++)
            {
                if ((contents[i].GetFirstName() == theFirstName) && (contents[i].GetLastName() == theLastName))
                    return contents[i];
            }
            return null;
        }

        // RemoveStudent removes an existing Student by name if found
        // returns -1 if not found
        public int RemoveStudent(String theFirstName, String theLastName)
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
            String tempString = "Students: ";
            for (int i = 0; i < currentSize - 1; i++)
            {
                tempString = tempString + contents[i].ToString();
            }
            tempString = tempString + Environment.NewLine;

            return tempString;
        }
    }
}
