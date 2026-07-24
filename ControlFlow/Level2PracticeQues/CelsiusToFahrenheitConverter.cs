using System;

namespace Level2PracticeQues
{
    internal static class CelsiusToFahrenheitConverter
    {
        public static void Run()
        {
            Console.Write("Enter Celsius: ");
            double celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($"The {celsius} Celsius is {fahrenheit:F2} Fahrenheit");
        }
    }
}