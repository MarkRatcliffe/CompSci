using System;

namespace Recursion
{
    class Program
    {
       
        public static void Main(string[] args)
        {
            Console.WriteLine("Demonstrating Recursion");
            Console.WriteLine("Iterative Factorial 10 = " + IterFactorial(10));
            Console.WriteLine("Factorial 10 = " + Factorial(10));
            Console.WriteLine("Fibonacci 7 = " + Fibonacci(7));
            Console.WriteLine("Reversing =");
            ProcessBackwards("Reversing");
            Console.ReadLine();
        }

        public static int IterFactorial(int n)
        {
            int answer = 1;
            for (int i = 2; i<= n; i++)
            {
                answer = answer * i;
            }
            return answer;
        }

        public static int Factorial(int n)
        {
            if (n == 1)
                return 1;

            return n * Factorial(n - 1);
        }

        public static int Fibonacci(int n)
        {
            if (n == 1)
                return 0;
            if (n == 2)
                return 1;
            return Fibonacci(n-1) + Fibonacci(n-2);
        }

        public static void ProcessBackwards(String word)
        {
            if (word.Length == 1)
                Console.Write(word);
            else
            {
                Console.Write(word.Substring(word.Length - 1, 1));
                ProcessBackwards(word.Substring(0, word.Length - 1));
            }
        }

    }
}
