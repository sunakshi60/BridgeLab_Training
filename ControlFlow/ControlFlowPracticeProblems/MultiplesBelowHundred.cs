using System;

namespace ControlFlowPracticeProblems
{
    internal static class MultiplesBelowHundred
    {
        public static void Run()
        {
            Console.Write("Enter Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Multiples of {number} below 100:");

            for (int i = 100; i >= 1; i--)
            {
                if (i % number == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}