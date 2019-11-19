using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "";
            int userAge = 0;

            int currentYear = 0;

            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the current year: ");
            currentYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}. Your age is {1}, and you were born in {2}.",
                              userName, userAge, currentYear - userAge);
            Console.ReadLine();
        }

    }
}
