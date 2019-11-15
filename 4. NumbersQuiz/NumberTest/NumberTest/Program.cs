using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This code originates from code written by Matt Hitchen

namespace NumberTest
{
    class Program
    {
        class Utilities
        {
            public Random rnd = new Random();

            public void displayMenu()
            {
                Console.WriteLine("What would you like to do now? ");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Integer Division");
                Console.WriteLine("4. Integer Multiplication");
                Console.WriteLine("5. Change Skill Level");
                Console.WriteLine("6. See your current score");
                Console.WriteLine("7. Exit the program.");
                Console.WriteLine("");
            }
            public int validateChoice(int min, int max)
            {
                int choice = min -1;
                while (choice < min | choice > max)
                {
                    Console.WriteLine("Please enter a value between {0} and {1}", min, max);
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                return choice;
            }

            // NOTE: the ref is used to indicate score goes in and comes out
            public void processScore(int correctAnswer, int userAnswer, ref int userScore)
            {
                if (userAnswer == correctAnswer)
                {
                    Console.WriteLine("Congratulations! You got the correct answer! 1 has been added to your score. ");
                    userScore = userScore + 1;
                    Console.WriteLine("Your score is now {0}!", userScore);
                }
                else
                {
                    Console.WriteLine("Incorrect. The answer is actually {0}", correctAnswer);
                    Console.WriteLine("Your current score is {0}.", userScore);
                }
            }
        }
           
        static void Main(string[] args)
        {
            Utilities myUtilities = new Utilities();

            int choice = 0;
            int score = 0;
            int minimum = 1;
            int maximum = 51;
            int num1, num2, correctAnswer, userAnswer;

            Console.WriteLine("Hello! Welcome to this Arithmetic Quiz! This is a scored quiz where 1 is added to your ongoing score with every correct answer you give. Good luck!");
            Console.WriteLine("");
            Console.WriteLine("");

            while (choice >= 1 | choice <= 7)
            {
                myUtilities.displayMenu();
                choice = myUtilities.validateChoice(1, 7);
                switch (choice)
                {
                    case 1:                 
                            num1 = myUtilities.rnd.Next(minimum, maximum);
                            num2 = myUtilities.rnd.Next(minimum, maximum);
                            correctAnswer = (num1 + num2);
                            Console.WriteLine("You have chosen Addition!");
                            Console.WriteLine("Your current skill range is {0} to {1}", minimum, maximum);
                            Console.WriteLine("What is...");
                            Console.WriteLine("{0} + {1} ? ", num1, num2);
                            userAnswer = Convert.ToInt32(Console.ReadLine());
                            /*
                            if (userAnswer == correctAnswer)
                            {
                                Console.WriteLine("Congratulations! You got the correct answer! 1 has been added to your score. ");
                                score = score + 1;
                                Console.WriteLine("Your score is now {0}!", score);
                            }
                            else
                            {
                                Console.WriteLine("Incorrect. The answer is actually {0}", correctAnswer);
                                Console.WriteLine("Your current score is {0}.", score);
                            }
                            */
                            // replacing the above with this:
                            // NOTE: the ref is used to indicate score goes in and comes out
                            myUtilities.processScore(correctAnswer, userAnswer, ref score);  
                            break;
                    case 2:
                            num1 = myUtilities.rnd.Next(minimum, maximum);
                            num2 = myUtilities.rnd.Next(minimum, maximum);
                            correctAnswer = (num1 - num2);
                            Console.WriteLine("You have chosen Subtraction!");
                            Console.WriteLine("Your current skill range is {0} to {1}", minimum, maximum);
                            Console.WriteLine("What is...");
                            Console.WriteLine("{0} - {1} ?", num1, num2);
                            userAnswer = Convert.ToInt32(Console.ReadLine());
                            myUtilities.processScore(correctAnswer, userAnswer, ref score);
                            break;                    
                    case 3:                
                            num1 = myUtilities.rnd.Next(minimum, maximum);
                            num2 = myUtilities.rnd.Next(minimum, maximum);
                            correctAnswer = (num1 % num2);

                            Console.WriteLine("You have chosen Integer Division!");
                            Console.WriteLine("Your current skill range is {0} to {1}", minimum, maximum);
                            Console.WriteLine("What is...");
                            Console.WriteLine("{0} / {1} ? (State the largest whole amount of times you can fit the divisor into the dividend) ", num1, num2);
                            userAnswer = Convert.ToInt32(Console.ReadLine());
                            myUtilities.processScore(correctAnswer, userAnswer, ref score);
                            Console.WriteLine("Ok, now what is the remainder you get from that division? ");
                            correctAnswer = (num1 / num2);
                            userAnswer = Convert.ToInt32(Console.ReadLine());
                            myUtilities.processScore(correctAnswer, userAnswer, ref score);
                            break;                 
                    case 4:                  
                            num1 = myUtilities.rnd.Next(minimum, maximum);
                            num2 = myUtilities.rnd.Next(minimum, maximum);
                            correctAnswer = (num1 * num2);
                            Console.WriteLine("You have chosen Integer Multiplication!");
                            Console.WriteLine("Your current skill range is {0} to {1}", minimum, maximum);
                            Console.WriteLine("What is...");
                            Console.WriteLine("{0} x {1} ?", num1, num2);
                            userAnswer = Convert.ToInt32(Console.ReadLine());
                            myUtilities.processScore(correctAnswer, userAnswer, ref score);
                            break;
                    case 5:
                            Console.WriteLine("You have opted to change the skill level of the quiz. What is the minimum whole number you would like to be used in the arithmetic questions?");
                            minimum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Thanks, now state what the maximum whole number you would to be used is.");
                            maximum = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Thank you. The skill level of the test has been changed. It is now {0} - {1}", minimum, maximum);
                            break;
        
                    case 6:
                            Console.WriteLine("Your current score is {0}", score);
                            break;
                    default:
                            Console.WriteLine("You have opted to exit. Your final score was {0}. ", score);
                            Console.ReadLine();
                            break;
                }

            }
        }
    }
}
