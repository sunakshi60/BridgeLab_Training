using System;

namespace PracticeQues
{
    internal static class DistanceKmToMiles
    {
        public static void Run()
        {
            Console.Write("Enter distance in kilometers: ");
            double km = double.Parse(Console.ReadLine());

            double miles = km / 1.6;

            Console.WriteLine($"The total miles is {miles:F2} mile for the given {km} km");
        }
    }
}