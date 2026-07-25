using System;

namespace ControlFlowPracticeProblems
{
    internal static class OddEvenPrinter
    {
        public static void Run()
        {
            Console.Write("Enter a natural number: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1)
            {
                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i} is Even");
                    }
                    else
                    {
                        Console.WriteLine($"{i} is Odd");
                    }
                }
            }
            else
            {
                Console.WriteLine($"{number} is not a natural number.");
            }
        }
    }
}