using System;

namespace PracticeQues
{
    internal static class FeetToYardsMilesConverter
    {
        public static void Run()
        {
            Console.Write("Enter Distance in Feet: ");
            double feet = double.Parse(Console.ReadLine());

            double yards = feet / 3;
            double miles = yards / 1760;

            Console.WriteLine($"The distance is {feet} feet, {yards:F2} yards and {miles:F4} miles");
        }
    }
}