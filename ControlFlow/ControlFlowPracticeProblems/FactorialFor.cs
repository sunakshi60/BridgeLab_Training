using System;

namespace ControlFlowPracticeProblems
{
    internal static class FactorialFor
    {
        public static void Run()
        {
            Console.Write("Enter a natural number: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1)
            {
                long factorial = 1;

                for (int i = 1; i <= number; i++)
                {
                    factorial *= i;
                }

                Console.WriteLine($"Factorial of {number} is {factorial}");
            }
            else
            {
                Console.WriteLine($"{number} is not a natural number.");
            }
        }
    }
}