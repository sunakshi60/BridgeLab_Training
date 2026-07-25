using System;

namespace ControlFlowPracticeProblems
{
    internal static class LeapYearChecker
    {
        public static void Run()
        {
            Console.Write("Enter Year: ");
            int year = int.Parse(Console.ReadLine());

            if (year < 1582)
            {
                Console.WriteLine("Leap year calculation is valid only for years 1582 and above.");
            }
            else if (year % 400 == 0)
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
            else if (year % 4 == 0)
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