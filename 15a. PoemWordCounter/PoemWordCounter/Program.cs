using System;

namespace PoemWordCounter
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            WordCounter dictionary = new WordCounter(100);
            string currentWord = "";

             // I should read in line of text
             // process line of text, looking for individual words
                   // for each word for WordCounter AddString

             // start with just a word at a time :-)
             while (currentWord != "STOP")
            {
                currentWord = Console.ReadLine();
                if (currentWord != "STOP")
                {
                    dictionary.AddString(currentWord);

                }
            }

        }
    }
}
