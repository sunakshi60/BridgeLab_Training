using System;

namespace ControlFlowPracticeProblems
{
    internal static class SumUntilZero
    {
        public static void Run()
        {
            double total = 0.0;

            Console.Write("Enter a number (0 to stop): ");
            double number = double.Parse(Console.ReadLine());

            while (number != 0)
            {
                total += number;

                Console.Write("Enter a number (0 to stop): ");
                number = double.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The total sum is {total}");
        }
    }
}