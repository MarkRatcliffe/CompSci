using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounting
{
    // This is a more straight forward class which can be used
    // instead of WordCounter
    class SimplerWordCountList
    {
        public class WordCount
        {
            public String word;
            public int count;
        }

        public WordCount[] theList;
        public int currentSize = 0;

        public SimplerWordCountList(int maxSize)
        {
            theList = new WordCount[maxSize];
        }

        public void AddWord (String theWord)
        {
            for (int i = 0; i < currentSize; i++)
            {
                if (theList[i].word == theWord)
                {
                    theList[i].count++;
                    return; // done so leave method
                }
            }
            // if we get here, then word doesn't exist
            theList[currentSize] = new WordCount();
            theList[currentSize].word = theWord;
            theList[currentSize].count = 1;
        }

    }
}
