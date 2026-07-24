using System;

namespace FewProblems
{
    internal static class KilometersToMilesConverter
    {
        public static void Run()
        {
            Console.Write("Enter Distance in Kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());

            double miles = kilometers * 0.621371;

            Console.WriteLine($"{kilometers} kilometers is equal to {miles:F2} miles");
        }
    }
}