using System;

namespace ControlFlowPracticeProblems
{
    internal static class SumUntilNegative
    {
        public static void Run()
        {
            double total = 0.0;

            while (true)
            {
                Console.Write("Enter a number (0 or negative to stop): ");
                double number = double.Parse(Console.ReadLine());

                if (number <= 0)
                {
                    break;
                }

                total += number;
            }

            Console.WriteLine($"The total sum is {total}");
        }
    }
}