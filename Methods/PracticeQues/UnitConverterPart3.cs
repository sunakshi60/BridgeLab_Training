using System;

namespace PracticeProblems
{
    internal static class UnitConverterPart3
    {
        public static void Run()
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine($"Celsius = {ConvertFahrenheitToCelsius(fahrenheit):F2}");
            Console.Write("Enter temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Fahrenheit = {ConvertCelsiusToFahrenheit(celsius):F2}");
            Console.Write("Enter weight in pounds: ");
            double pounds = double.Parse(Console.ReadLine());
            Console.WriteLine($"Kilograms = {ConvertPoundsToKilograms(pounds):F2}");
            Console.Write("Enter weight in kilograms: ");
            double kilograms = double.Parse(Console.ReadLine());
            Console.WriteLine($"Pounds = {ConvertKilogramsToPounds(kilograms):F2}");
            Console.Write("Enter volume in gallons: ");
            double gallons = double.Parse(Console.ReadLine());
            Console.WriteLine($"Liters = {ConvertGallonsToLiters(gallons):F2}");
            Console.Write("Enter volume in liters: ");
            double liters = double.Parse(Console.ReadLine());
            Console.WriteLine($"Gallons = {ConvertLitersToGallons(liters):F2}");
        }

        public static double ConvertFahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
        public static double ConvertCelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
        public static double ConvertPoundsToKilograms(double pounds)
        {
            return pounds * 0.453592;
        }
        public static double ConvertKilogramsToPounds(double kilograms)
        {
            return kilograms * 2.20462;
        }
        public static double ConvertGallonsToLiters(double gallons)
        {
            return gallons * 3.78541;
        }
        public static double ConvertLitersToGallons(double liters)
        {
            return liters * 0.264172;
        }
    }
}