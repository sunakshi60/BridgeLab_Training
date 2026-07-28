using System;

namespace PracticeProblems
{
    internal static class SumOfNaturalNumbersUsingRecursion
    {
        public static void Run()
        {
            Console.Write("Enter a natural number: ");
            int number = int.Parse(Console.ReadLine());
            if (number <= 0)
            {
                Console.WriteLine("Please enter a natural number.");
                return;
            }
            int recursiveSum = FindSumUsingRecursion(number);
            int formulaSum = FindSumUsingFormula(number);

            Console.WriteLine($"Sum using Recursion = {recursiveSum}");
            Console.WriteLine($"Sum using Formula = {formulaSum}");
            if (recursiveSum == formulaSum)
            {
                Console.WriteLine("Both results are correct.");
            }
            else
            {
                Console.WriteLine("Results are different.");
            }
        }

        public static int FindSumUsingRecursion(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number + FindSumUsingRecursion(number - 1);
        }

        public static int FindSumUsingFormula(int number)
        {
            return number * (number + 1) / 2;
        }
    }
}
