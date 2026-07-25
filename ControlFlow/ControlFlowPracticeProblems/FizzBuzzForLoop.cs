using System;

namespace ControlFlowPracticeProblems
{
    internal static class FizzBuzzForLoop
    {
        public static void Run()
        {
            Console.Write("Enter a Positive Number: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Enter a positive number: ");
                return;
            }

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}