using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace WordCounting
{
    public class WordCounter
    {
        public class WordCountPair
        {
            public String theWord;
            public int theCount = 0;

            public WordCountPair(String aWord)
            {
                theWord = aWord;
                theCount = 0;
             }

            public override string ToString()
            {
                return theWord + " " + theCount;
            }
        }

        private WordCountPair[] theList;
        private int currentSize;


        public WordCounter (int maxSize)
        {
            theList = new WordCountPair[maxSize];
            currentSize = 0;
        }

        // findIndexOfWord returns 0 if Word not found
        public int FindIndexOfWord(String theString)
        {
            for (int i = 0; i < currentSize; i++)
            {
                if (theList[i].theWord == theString)
                {
                    // found word so pass index
                    return i;
                }
            }
            // if we get here we haven't foudn the Word
            return -1;
        }

        // GetCountByWord returns the Count of a Word, -1 if it doesnt exist
        public int GetCountByWord(String theString)
        {
            int location = FindIndexOfWord(theString);
            if (location != -1)
            {
                return theList[location].theCount;
            }
            else
            {
                return -1;
            }
        }


        // AddWord adds a Word into the structure, or increments counter for existing word
        // returns -1 if unable to add - array is full
        public int AddWord(String theWord)
        {
            int location = FindIndexOfWord(theWord);
            // check whether Word is in the list
            if (location == -1)
            {
                // Word now found, so add word to our list, setting counter to zero
                if (currentSize < theList.Length)
                {
                    theList[currentSize] = new WordCountPair(theWord);
                    currentSize++;
                }
                else
                {
                    return -1; // could not add, array is full
                }
            }
            else
            {
                // So Word is already in list; increment counter
                theList[location].theCount = theList[location].theCount + 1;
            }
            // All is OK so leave and return 0
            return 0;
        }

        // loadWordsFromFile loads a file and processes text
        public int loadWordsFromFile(String fileName)
        {
            StreamReader theInputStream = new StreamReader(fileName);

            // Now lets process the file, a line at a time
            String theLine;
            char[] delimiter = new Char[] {' ','.',',','\n'};
            while (!theInputStream.EndOfStream)
            {
                theLine = theInputStream.ReadLine();
                // now process the line
                string[] tokenizedString = theLine.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                
                // Now we process each String in the string array
                for (int i =0; i < tokenizedString.Length; i++)
                {
                    AddWord(tokenizedString[i]);
                }
            }

            theInputStream.Close();

            Console.ReadLine();
            return 0;
        }

        public override String ToString()
        {
            String theResult = "";
            for (int i=0; i < currentSize; i++)
            {
                theResult = theResult + theList[i].ToString() + Environment.NewLine;
            }
            return theResult;
        }

    }
}
