using System;

namespace PracticeProblems
{
    internal static class LeapYear
    {
        public static void Run()
        {
            Console.Write("Enter a year: ");
            int year = int.Parse(Console.ReadLine());
            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a Leap Year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }

        public static bool IsLeapYear(int year)
        {
            if (year < 1582)
            {
                return false;
            }
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}