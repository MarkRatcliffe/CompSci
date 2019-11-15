using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// We use this to give access to StopWatch for diagnostics
using System.Diagnostics;


namespace SortingII
{
    class Program
    {

        static void Main(string[] args)
        {

            InsertionSort mySorting = new InsertionSort();

            int[] smallList = { 10, 3, 9, 2, 8, 4, 6, 7, 5 };
            int[] longList = new int[9999];

            mySorting.DisplayList(smallList);
            mySorting.InsertSort(ref smallList);
            mySorting.DisplayList(smallList);

            Console.WriteLine("Now timing long list sorting...");

            Random rnd = new Random();

            for (int i = 0; i < longList.Length; i++)
            {
                longList[i] = rnd.Next(1, 101); // creates a number between 1 and 100
            }

            Stopwatch bsStopwatch = new Stopwatch();
            bsStopwatch.Start();
            mySorting.InsertSort(ref longList);
            bsStopwatch.Stop();
            Console.WriteLine("Time taken for standard Insertion Sort on long List is " + bsStopwatch.Elapsed.TotalSeconds);

            Console.ReadLine();
        }
    }
}
