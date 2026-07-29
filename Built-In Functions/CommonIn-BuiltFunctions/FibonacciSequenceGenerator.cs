using System;

namespace CommonIn_BuiltFunctions
{
    class FibonacciSequenceGenerator
    {
        public static void Run()
        {
            int terms = GetTerms();
            Console.WriteLine("Fibonacci Sequence:");
            PrintFibonacci(terms);
        }

        static int GetTerms()
        {
            Console.Write("Enter the Number of Terms: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void PrintFibonacci(int terms)
        {
            int first = 0;
            int second = 1;

            for (int i = 1; i <= terms; i++)
            {
                Console.Write(first + " ");
                int next = first + second;
                first = second;
                second = next;
            }
        }
    }
}