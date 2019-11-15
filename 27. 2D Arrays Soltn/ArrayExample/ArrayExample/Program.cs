using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Program
    {
        public class arrayRoutine
        {
            public void Fill2DArrayWithRandom(ref int[,] arr)
            {
                Random rnd = new Random();

                for (int row = 0; row <= arr.GetUpperBound(0); row++)
                {
                    for (int column = 0; column <= arr.GetUpperBound(1); column++)
                    {
                        arr[row, column] = rnd.Next(0, 101);
                    }
                }
            }

            public void Display2DArray(int[,] arr)
            {
                {
                    for (int row = 0; row <= arr.GetUpperBound(0); row++)
                        for (int column = 0; column <= arr.GetUpperBound(1); column++)
                    {
                        Console.Write(arr[row, column] + "\t");
                    }
                    Console.WriteLine();
                }
            }
        }

        public static void Main(string[] args)
        {
            arrayRoutine my2Darray = new arrayRoutine();
            int[,] tempArray = new int[10, 10];

            my2Darray.Fill2DArrayWithRandom(ref tempArray);
            my2Darray.Display2DArray(tempArray);
            Console.ReadLine();
        }
    }
}

