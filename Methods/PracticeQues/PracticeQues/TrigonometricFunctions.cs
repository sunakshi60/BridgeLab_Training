using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal class TrigonometricFunctions
    {
        public static void Run()
        {
            Console.Write("Enter angle in degrees: ");
            double angle = double.Parse(Console.ReadLine());

            double[] result = CalculateTrigonometricFunctions(angle);

            Console.WriteLine($"Sine = {result[0]:F4}");
            Console.WriteLine($"Cosine = {result[1]:F4}");
            Console.WriteLine($"Tangent = {result[2]:F4}");
        }

        public static double[] CalculateTrigonometricFunctions(double angle)
        {
            double radians = angle * Math.PI / 180;

            double sine = Math.Sin(radians);
            double cosine = Math.Cos(radians);
            double tangent = Math.Tan(radians);

            return new double[] { sine, cosine, tangent };
        }
    }
}
