using System;

namespace ControlFlowPracticeProblems
{
    internal static class FactorFinder
    {
        public static void Run()
        {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Factors:");

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}