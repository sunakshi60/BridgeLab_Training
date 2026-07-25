using System;

namespace ControlFlowPracticeProblems
{
    internal static class FactorialWhile
    {
        public static void Run()
        {
            Console.Write("Enter a natural number: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1)
            {
                long factorial = 1;
                int i = 1;

                while (i <= number)
                {
                    factorial *= i;
                    i++;
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