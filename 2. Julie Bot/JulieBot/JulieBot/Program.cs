using System;

namespace JulieBot
{
    class Program
    {
        static void Main(string[] args)
        {

            // http://www.botlibre.com/bot?instance=667676&dynamicChat=Chat
            // Login with: Username Wigmore    Password Wigmore
            // Then return to original web address
            string name;
            int telNum = 0;

            // Start by introducing program to user
            Console.WriteLine("Hello, my name is Julie");

            // Ask user their name - follow with newline
            Console.WriteLine("What is your name");
            name = Console.ReadLine();

            // Say hello to user
            Console.Write("Hello " + name + ".");
            Console.WriteLine("Hope you are having a good day?");

            // Ask user what their tel num is
            Console.WriteLine("What is your telephone number (no spaces please)?");
            telNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("I will phone you later on " + telNum);

            Console.WriteLine("See you later " + name);

            // Did you spot the serious error!
            // Keep window on screen waiting for more input
            Console.ReadLine();
        }
    }
}
  