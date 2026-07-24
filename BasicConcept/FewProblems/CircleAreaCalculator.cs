using System;

namespace FewProblems
{
    internal static class CircleAreaCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Radius: ");
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;

            Console.WriteLine($"Area of Circle is {area:F2}");
        }
    }
}