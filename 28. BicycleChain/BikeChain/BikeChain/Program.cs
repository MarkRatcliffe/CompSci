using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeChain
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Ring = new int[8];
            // Note the question refers to a one-based array!
            // I am using a zero-based array

            int maxRings = 8;
            Console.WriteLine("Please enter the number of rings");
            int userRings = Convert.ToInt32(Console.ReadLine());
            int lastTooth = 99;  // stores the value of the last teeth to check; subsequent ones are less
            int currentTooth = 0;
            for (int i = 0; i < maxRings;) // Note I'm not inclusing i++ - I do that in the code
            {
                if (i < userRings)
                {
                    Console.WriteLine("Enter number of teeth");
                    currentTooth = Convert.ToInt32(Console.ReadLine());
                    if (currentTooth >= lastTooth)
                    {
                        Console.WriteLine("Each cog must be smaller than the last - try again");
                    }
                    else
                    {
                        Ring[i] = currentTooth;
                        lastTooth = currentTooth;  // this is now the largest tooth
                        i++;   // we can now move onto the next
                    }
                }
                else
                {
                    Ring[i] = 0;
                    i++;
                }
            }

            // Now checking that it worked
            for (int i =0; i < maxRings; i++)
            {
                Console.WriteLine(Ring[i]);
            }
            Console.ReadLine();
        }


    }
}
