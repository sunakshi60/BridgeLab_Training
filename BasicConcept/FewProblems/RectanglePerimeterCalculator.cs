using System;

namespace FewProblems
{
    internal static class RectanglePerimeterCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter Width: ");
            double width = double.Parse(Console.ReadLine());

            double perimeter = 2 * (length + width);

            Console.WriteLine($"Perimeter of Rectangle is {perimeter}");
        }
    }
}