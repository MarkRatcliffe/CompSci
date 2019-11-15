using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HangmanGame.Properties;

namespace HangmanGame
{
    public class Hangman
    {
        private String lettersAlreadyUsed = "";

        private String currentWord = "";     // the current game word, set by refreshWord

        // currentReveal is a StringBuilder so I can edit it   e.g. currentReveal[i] = e
        private StringBuilder  currentReveal;   // the current status  e.g.  e _ e _ _ _ _ _ 


        private Player[] thePlayers;

        public String[] dictionary;  // System UNDER TEST - will revert to private later

        private Random rnd = new Random();

        public Hangman(String player1, String player2)
        {
            // constructor sets up players
            // Either like this:   thePlayers = new Player[2] {new Player(player1), new Player(player2)};

            thePlayers = new Player[2];
            thePlayers[0] = new Player(player1);
            thePlayers[1] = new Player(player2);
        }

        // A private method, used internally to set the current word from dictionary, and convert to lower case 
        private String getRandomWord()
        {
            return dictionary[rnd.Next(0, dictionary.Length)].ToLower();
        }

        //restartWithNewWord selects a new word, and sets the current reveal to underscores
        public void restartWithNewWord()
        { 
            currentWord = getRandomWord();
            currentReveal = new StringBuilder(currentWord);
            for (int i=0; i< currentWord.Length; i++)
            {
                currentReveal[i] = '_';
            }
        }

        // returns the current word i.e. the answer
        public String getCurrentWord()
        {
            return currentWord;
        }

        // returns the current reveal e.g. e_e_____
        public String getReveal()
        {
            return currentReveal.ToString();
        }

        // returns a String of letters already used
        public String getLettersAlreadyUsed()
        {
            return lettersAlreadyUsed;
        }

        // makeGuess - takes in the current guess
        // Updates currentReveal and returns appropriate code
        //  +ve - number of occurences that letter is found
        //  0  letter not found 
        // -1 letter has already been used - so ignored
        public int makeGuess(char theLetter)
        {
            int correctCount = 0;
            if (lettersAlreadyUsed.Contains(theLetter))
            {
                return -1;
            }
            if (currentWord.Contains(theLetter))
            {
                lettersAlreadyUsed = lettersAlreadyUsed + theLetter;

                // now replace the _ with correctly guessed letters
                for (int i = 0; i < currentWord.Length; i++)
                {
                    if (currentWord[i] == theLetter)
                    {
                        currentReveal[i] = theLetter;
                        correctCount++;
                    }
                }
            }
            return correctCount;   // will still be zero if not found
        }


        // loadDictionaryFromExternalFile loads in a list of names from the file
        // returns 0 if all OK, else returns a negative error code
        public int loadDictionaryFromFile(String filePath)
        {
            String line;
            int lineCount = 0;

            String[] tempDictionary = new String[100];
            if (!File.Exists(filePath))      // the file doesn't exist
            {
                Console.WriteLine("Can't find {0}", filePath);
                return -1;
            }
   
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader myStreamReader = new StreamReader(filePath);

                //Read the first line of text
                line = myStreamReader.ReadLine();

                //Continue to read until you reach end of file
                while (line != null)
                {
                    //store the line in the dictionary
                    tempDictionary[lineCount] = line;
                    lineCount++;
                    //Read the next line
                    line = myStreamReader.ReadLine();
                }

                //close the file
                myStreamReader.Close();

                // Now we assign the dictionary
                dictionary = new String[lineCount];   // we create the cporrect 
                Array.Copy(tempDictionary, dictionary, lineCount);

                // if we got here, all is ok
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                return -2;
            }

        }

        // loadDefaultDictionary loads in the default file held in resources
        // returns 0 if all OK, else returns a negative error code
        public int loadDictionaryDefault()
        {
            String[] tempDictionary = new String[100];
            String line;
            int lineCount = 0;
            string fileContent = Resources.hangman;
            using (var reader = new StringReader(fileContent))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    tempDictionary[lineCount] = line;
                    lineCount++;
                }
            }

            // Now we assign the dictionary
            dictionary = new String[lineCount];   // we create the cporrect 
            Array.Copy(tempDictionary, dictionary, lineCount);

            return 0;
        }
    }
}
