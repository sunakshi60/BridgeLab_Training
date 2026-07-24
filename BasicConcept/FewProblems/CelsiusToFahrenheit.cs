using System;

namespace FewProblems
{
    internal static class CelsiusToFahrenheit
    {
        public static void Run()
        {
            Console.Write("Enter Temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"{celsius}°C is equal to {fahrenheit:F2}°F");
        }
    }
}