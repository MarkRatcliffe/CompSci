using System;

namespace RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            void ProgramRemote()
            {
                Console.WriteLine("This is where I will code Program Remote");

            }
            void DisplayRemote()
            {
                Console.WriteLine("This is where I will display settings for Program Remote");

            }

            void runRemote()
            {
                Console.WriteLine("This is where I will code the running of Program Remote");

            }
            int option = 4;
            do
            {
                Console.WriteLine("Welcome to remote control");
                Console.WriteLine("Which option do you require?");
                Console.WriteLine("1. Program your remote control");
                Console.WriteLine("2. Display commands");
                Console.WriteLine("3. Run");
                Console.WriteLine("4. Quit");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        ProgramRemote();
                        break;
                    case 2:
                        DisplayRemote();
                        break;
                    case 3:
                        runRemote();
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using the Remote Control");
                        break;
                }
            } while (option != 4);

            Console.WriteLine("Bye");
            Console.ReadLine(); // keep screen visible to allow user to read then die
        }
    }
}
