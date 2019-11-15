using System;

namespace SortedNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Names myNames = new Names();
            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("Enter your name");
                if (!myNames.Add(Console.ReadLine()))
                {
                    Console.WriteLine("oops array must be full");
                }
            }
            Console.WriteLine("The names you entered are");
            myNames.DisplayNames();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("What name do you want to find");
                Console.WriteLine("It was in position " + myNames.FindName(Console.ReadLine()));
            }

            Console.ReadLine();   // wait here for user

        }

    }
}
