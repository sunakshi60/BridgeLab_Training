using System;

namespace PracticeQues
{
    internal static class TriangleAreaCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Base (cm): ");
            double baseValue = double.Parse(Console.ReadLine());

            Console.Write("Enter Height (cm): ");
            double height = double.Parse(Console.ReadLine());

            double areaCm = 0.5 * baseValue * height;
            double areaInch = areaCm / 6.4516;

            Console.WriteLine($"Area of triangle is {areaCm:F2} square centimeters and {areaInch:F2} square inches");
        }
    }
}