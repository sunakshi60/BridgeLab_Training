using System;

namespace ControlFlowPracticeProblems
{
    internal static class FizzBuzzWhileLoop
    {
        public static void Run()
        {
            Console.Write("Enter a Positive Number: ");
            int number = int.Parse(Console.ReadLine());

            int i = 1;

            while (i <= number)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);

                i++;
            }
        }
    }
}