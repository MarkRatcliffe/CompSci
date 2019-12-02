using System;
using System.Collections.Generic;
using System.Text;

namespace PoemWordCounter
{
    class WordCounter
    {
        private WordCountPair[] collection; 
        private int nextFreeLocation = 0;

        // constructor takes a parameter to specify how big the array should be
        public WordCounter(int maxSize)
        {
            collection = new WordCountPair[maxSize];
        }

        // AddWord takes in a new word, adds it to the collection and returns current count for that word
        // Passes back -1 if it can't be added
        public int AddString (String newWord)
        {
            // check length of array, if full return -1
            if (nextFreeLocation > collection.Length)
                return -1;

            // search through array to see if it exists
            int position = FindPositionOfName(newWord);

            // if newWord is found then simply add 1 to the existing count, return new count
            if (position != -1) // name exists
            {
                collection[position].SetCount(collection[position].GetCount() + 1);
                return collection[position].GetCount(); // pass back new count
            }

            // if newWord is not found then add into collection (AddNewNameToList)
            // maintaining order, then return new count
            return collection[AddNewNameToList(newWord)].GetCount();
            

        }

        // AddNewNameToList takes in a name, adds it to the list maintaining the order
        // passes back an integer (-1 if error), giving inserted location
        public int AddNewNameToList(string theWord)
        {
            // now locate position to insert new name 
            int position = 0;

            while ((position < nextFreeLocation) &&
                   (collection[position].CompareTo(theWord) < 0))
            {
                position = position + 1;
            }

            // now do shunting - step 2 above
            for (int i = nextFreeLocation; i > position; i--)
            {
                collection[i] = collection[i - 1];
            }

            // now insert theName into position - step 3 above
            collection[position] = new WordCountPair(theWord,1);

            // increment nextFreeLocation for next time - step 4 above
            nextFreeLocation++;

            // pass back the position we inserted theName
            return position;
        }

        // FindPositionOfName locates a name in the list
        // passes back an integer (-1 if error), giving inserted location
        public int FindPositionOfName(string theNewWord)
        {
            for (int i=0; i < nextFreeLocation; i++)
            {
                if (collection[i].CompareTo(theNewWord) == 0)
                    return i;
            }
            // if we get here, we haven't found the string in the collection
            return -1;
        }

        public override string ToString()
        {
            String theString = "";
            //  go through array, and for each entry add Word,Count and newline to String
            for (int i=0; i < nextFreeLocation; i++)
            {
                theString = theString + collection[i] + Environment.NewLine;
            }
            return theString;
        }
    }
}
