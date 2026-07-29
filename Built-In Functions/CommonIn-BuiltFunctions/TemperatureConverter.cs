using System;

namespace CommonIn_BuiltFunctions
{
    class TemperatureConverter
    {
        public static void Run()
        {
            Console.WriteLine("Temperature Converter");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            if (choice == 1)
            {
                double fahrenheit = CelsiusToFahrenheit(temperature);
                Console.WriteLine("Temperature in Fahrenheit = " + fahrenheit);
            }
            else if (choice == 2)
            {
                double celsius = FahrenheitToCelsius(temperature);
                Console.WriteLine("Temperature in Celsius = " + celsius);
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }
        }

        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }
    }
}