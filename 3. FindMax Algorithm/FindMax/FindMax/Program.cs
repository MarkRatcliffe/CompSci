using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] theList = new int[10];
            // lets create a random number generator for numbers 1 to 100
            Random rnd = new Random();

            // Let's start by populating as array of 10 numbers
            for (int i = 0; i < 10; i++)
            {
                // set item in array to a random number 0 to 99
                theList[i] = rnd.Next(0,100);
            }

            // let's now display the list, one item at a time
            for (int i = 0; i < 10; i++)
            {
                Console.Write(theList[i] + " ");
            }
            Console.WriteLine();

            // Now find the maximum number
            int biggest = findMax(theList);

            Console.WriteLine("The largest number is " + biggest);

            // Keep window on screen waiting for more input
            Console.ReadKey();

        }
        static int findMax(int[] tempList)
        {
            int biggest = 0;
            for (int i = 0; i < tempList.Length; i++)
            {
                if (tempList[i] > biggest)
                {
                    biggest = tempList[i];
                }
            }
            return biggest;
        }
    }
}
