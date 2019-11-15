using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownByRef
{
    class Program
    {
        public class Utils
        {
            public void CountDown(int intCountValue)
            {
                if (intCountValue >= 0)
                {
                    do
                    {
                        Console.WriteLine(intCountValue + " ...");
                        intCountValue = intCountValue - 1;
                    } while (intCountValue != 0);
                }
            }
        }


        static void Main(string[] args)
        {
            Utils myUtils = new Utils();
            int intStartValue;
            Console.Write("Count down from ?");
            intStartValue = Convert.ToInt32(Console.ReadLine());
            myUtils.CountDown(intStartValue);
            Console.WriteLine("You counted down to {0}", intStartValue);
            Console.ReadLine(); // keep window visible
        }
    }
}
