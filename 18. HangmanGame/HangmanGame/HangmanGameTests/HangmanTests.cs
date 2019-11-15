using Microsoft.VisualStudio.TestTools.UnitTesting;
using HangmanGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame.Tests
{
    [TestClass()]
    public class HangmanTests
    {
        [TestMethod()]

        public void loadDictionaryFromFileTest()
        {
            Hangman myGame = new Hangman("user1", "user2");
            int result = myGame.loadDictionaryFromFile("\\\\internal.hereford.ac.uk\\staff\\Home\\mbr\\My Documents\\hangman.txt");
            // int result = myGame.loadDictionaryFromFile("C:\\Users\\markr\\Desktop\\hangman.txt");
            Assert.AreEqual(result, 0);
            Assert.AreNotEqual(myGame.dictionary, null);

            if (myGame.dictionary != null)
            {
                for (int i = 0; i < myGame.dictionary.Length; i++)
                {
                    Console.WriteLine(myGame.dictionary[i]);
                }
            }
        }

        [TestMethod()]
        public void loadDictionaryDefaultTest()
        {
            Hangman myGame = new Hangman("user1", "user2");
            int result = myGame.loadDictionaryDefault();
            Console.WriteLine("result = {0} ", result);
            Assert.AreNotEqual(myGame.dictionary, null);

            for (int i = 0; i < myGame.dictionary.Length; i++)
            {
                Console.WriteLine(myGame.dictionary[i]);
            }
        }

        [TestMethod()]
        public void makeGuessTest()
        {
            Hangman myGame = new Hangman("user1", "user2");
            int result = myGame.loadDictionaryFromFile("\\\\internal.hereford.ac.uk\\staff\\Home\\mbr\\My Documents\\hangman.txt");
            // int result = myGame.loadDictionaryFromFile("C:\\Users\\markr\\Desktop\\hangman.txt");
            Assert.AreEqual(result, 0);

            loadDictionaryFromFileTest();
            myGame.restartWithNewWord();
            String answer = myGame.getCurrentWord();               // this gives us the correct word
            Console.WriteLine("Current Word {0}", answer);
            Assert.AreEqual('_', myGame.getReveal()[0]);           // revealed letter should initially be _
            Console.WriteLine("Revealed Word{0}", myGame.getReveal());
            Assert.AreNotEqual(0, myGame.makeGuess(answer[0]));     // guess using first char in word
            Console.WriteLine("Revealed Word{0}", myGame.getReveal());
            Assert.AreEqual(answer[0], (myGame.getReveal()[0]));   // letter should now be the reveal
            Assert.AreEqual(0, myGame.makeGuess('*'));             // should not be present
            Assert.AreEqual(true, myGame.getLettersAlreadyUsed().Contains(answer[0]));
        }

    }
}