using System;

namespace ControlFlowPracticeProblems
{
    internal static class MultiplicationTable
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {number * i}");
            }
        }
    }
}