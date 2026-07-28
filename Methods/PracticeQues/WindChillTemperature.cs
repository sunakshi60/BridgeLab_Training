using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal static class WindChillTemperature
    {
        public static void Run()
        {
            Console.Write("Enter temperature: ");
            double temperature = double.Parse(Console.ReadLine());
            Console.Write("Enter wind speed: ");
            double windSpeed = double.Parse(Console.ReadLine());
            double windChill = CalculateWindChill(temperature, windSpeed);
            Console.WriteLine($"Wind Chill Temperature = {windChill:F2}");
        }
        public static double CalculateWindChill(double temperature, double windSpeed)
        {
            return 35.74 + (0.6215 * temperature) +(0.4275 * temperature - 35.75) *Math.Pow(windSpeed, 0.16);
        }
    }
}
