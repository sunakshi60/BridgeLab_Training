using System;

namespace Level2PracticeQues
{
    internal static class FahrenheitToCelsiusConverter
    {
        public static void Run()
        {
            Console.Write("Enter Fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsius:F2} Celsius");
        }
    }
}