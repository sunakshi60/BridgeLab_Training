using System;

namespace ControlFlowPracticeProblems
{
    internal static class NaturalNumberSumFor
    {
        public static void Run()
        {
            Console.Write("Enter a natural number: ");
            int number = int.Parse(Console.ReadLine());

            if (number >= 1)
            {
                int sum = 0;

                for (int i = 1; i <= number; i++)
                {
                    sum += i;
                }

                int formulaSum = number * (number + 1) / 2;

                Console.WriteLine($"Sum using for loop = {sum}");
                Console.WriteLine($"Sum using formula = {formulaSum}");
                Console.WriteLine($"Both results are equal? {sum == formulaSum}");
            }
            else
            {
                Console.WriteLine($"{number} is not a natural number.");
            }
        }
    }
}