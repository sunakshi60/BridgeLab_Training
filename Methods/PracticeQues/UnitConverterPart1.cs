using System;

namespace PracticeProblems
{
    internal static class UnitConverterPart1
    {
        public static void Run()
        {
            Console.Write("Enter distance in kilometers: ");
            double kilometers = double.Parse(Console.ReadLine());
            Console.WriteLine($"Miles = {ConvertKmToMiles(kilometers):F2}");
            Console.Write("Enter distance in miles: ");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine($"Kilometers = {ConvertMilesToKm(miles):F2}");
            Console.Write("Enter length in meters: ");
            double meters = double.Parse(Console.ReadLine());
            Console.WriteLine($"Feet = {ConvertMetersToFeet(meters):F2}");
            Console.Write("Enter length in feet: ");
            double feet = double.Parse(Console.ReadLine());
            Console.WriteLine($"Meters = {ConvertFeetToMeters(feet):F2}");
        }

        public static double ConvertKmToMiles(double km)
        {
            return km * 0.621371;
        }
        public static double ConvertMilesToKm(double miles)
        {
            return miles * 1.60934;
        }
        public static double ConvertMetersToFeet(double meters)
        {
            return meters * 3.28084;
        }
        public static double ConvertFeetToMeters(double feet)
        {
            return feet * 0.3048;
        }
    }
}