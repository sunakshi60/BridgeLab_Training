using System;

namespace FewProblems
{
    internal static class CylinderVolumeCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Radius: ");
            double radius = double.Parse(Console.ReadLine());

            Console.Write("Enter Height: ");
            double height = double.Parse(Console.ReadLine());

            double volume = Math.PI * radius * radius * height;

            Console.WriteLine($"Volume of Cylinder is {volume:F2}");
        }
    }
}