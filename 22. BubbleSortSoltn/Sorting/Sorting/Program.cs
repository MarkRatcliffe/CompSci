using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// We use this to give access to StopWatch for diagnostics
using System.Diagnostics;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            BubbleSort myBubbles = new BubbleSort();

            int[] smallList = { 10, 3, 9, 2, 8, 4, 6, 7, 5 };
            int[] longList = new int[9999];
            int[] longListDuplicate = new int[9999];

            myBubbles.DisplayList(smallList);
            
            myBubbles.StandardBubbleSort(ref smallList);

            myBubbles.DisplayList(smallList);

            Console.WriteLine("Now timing long list sorting...");

            Random rnd = new Random();

            for (int i = 0; i < longList.Length; i++)
            {
                longList[i] = rnd.Next(1, 101); // creates a number between 1 and 100
            }

            for (int i = 0; i < longListDuplicate.Length; i++)
            {
                longListDuplicate[i] = longList[i];
            }

            Stopwatch bsStopwatch = new Stopwatch();
            bsStopwatch.Start();
            myBubbles.StandardBubbleSort(ref longList);
            bsStopwatch.Stop();
            Console.WriteLine("Time taken for standard BubbleSort on long List is " + bsStopwatch.Elapsed.TotalSeconds);

            Stopwatch sbsStopwatch = new Stopwatch();
            sbsStopwatch.Start();
            myBubbles.ShortBubbleSort(ref longListDuplicate);
            sbsStopwatch.Stop();
            Console.WriteLine("Time taken for short BubbleSort on long List Duplicate is " + sbsStopwatch.Elapsed.TotalSeconds);

            Console.ReadLine();
        }
    }
}
