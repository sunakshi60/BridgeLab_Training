using System;

namespace ControlFlowPracticeProblems
{
    internal static class DivisibleByFive
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            bool isDivisible = number % 5 == 0;

            Console.WriteLine($"Is the number {number} divisible by 5? {isDivisible}");
        }
    }
}