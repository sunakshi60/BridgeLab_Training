using System;

namespace PracticeQues
{
    internal static class KmToMiles
    {
        public static void Run()
        {
            Console.Write("Enter Distance in KM: ");
            double kilometers = double.Parse(Console.ReadLine());

            double miles = kilometers / 1.6;

            Console.WriteLine($"\nThe distance {kilometers} km in miles is {miles:F2} miles.");
        }
    }
}