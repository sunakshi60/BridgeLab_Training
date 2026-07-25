using System;

namespace ControlFlowPracticeProblems
{
    internal static class LeapYearSingleIf
    {
        public static void Run()
        {
            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());

            if (year >= 1582 &&
               ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0))
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }
    }
}