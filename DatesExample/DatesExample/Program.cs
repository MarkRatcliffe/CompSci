using System;

namespace DatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int CalculateDays(int month)
            {
                int numOfDays = 0;
                switch (month)
                {
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        numOfDays = 30;
                        break;
                    case 2:
                        numOfDays = 28;   // ignoring leap year
                        break;
                    default:
                        numOfDays = 31;
                        break;
                }
                return numOfDays;
            }
            void DisplayMonth(int monthNumber)
            {
                int daysToDisplay = CalculateDays(monthNumber);

                for (int count = 1; count <= daysToDisplay; count++)
                {
                    Console.Write(count + "\t");   // this adds a tab
                    if (count % 7 == 0)
                    {
                        Console.WriteLine();  // new line after 7's
                    }
                }
                Console.WriteLine();  // new line after last row
            }

            // this is my main program
            Console.WriteLine("Welcome to my calendar");
            for (int theMonth = 1; theMonth <= 12; theMonth++)
            {
                Console.WriteLine("\t\t\t  Month " + theMonth);
                DisplayMonth(theMonth);
                
            }
            Console.ReadLine();
        }
    }
}
