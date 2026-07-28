using System;

namespace PracticeProblems
{
    internal static class UnitConverterPart2
    {
        public static void Run()
        {
            Console.Write("Enter length in yards: ");
            double yards = double.Parse(Console.ReadLine());
            Console.WriteLine($"Feet = {ConvertYardsToFeet(yards):F2}");
            Console.Write("Enter length in feet: ");
            double feet = double.Parse(Console.ReadLine());
            Console.WriteLine($"Yards = {ConvertFeetToYards(feet):F2}");
            Console.Write("Enter length in meters: ");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine($"Inches = {ConvertMetersToInches(meters):F2}");
            Console.Write("Enter length in inches: ");
            double inches = double.Parse(Console.ReadLine());
            Console.WriteLine($"Meters = {ConvertInchesToMeters(inches):F2}");
            Console.WriteLine($"Centimeters = {ConvertInchesToCentimeters(inches):F2}");
        }
        public static double ConvertYardsToFeet(double yards)
        {
            return yards * 3;
        }
        public static double ConvertFeetToYards(double feet)
        {
            return feet * 0.333333;
        }
        public static double ConvertMetersToInches(double meters)
        {
            return meters * 39.3701;
        }
        public static double ConvertInchesToMeters(double inches)
        {
            return inches * 0.0254;
        }
        public static double ConvertInchesToCentimeters(double inches)
        {
            return inches * 2.54;
        }
    }
}