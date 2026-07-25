using System;

namespace ControlFlowPracticeProblems
{
    internal static class PowerCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Enter Power: ");
            int power = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }

            Console.WriteLine($"Result = {result}");
        }
    }
}