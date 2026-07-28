using System;

namespace PracticeQues
{
    internal static class EuclideanDistanceAndLineEquation
    {
        public static void Run()
        {
            Console.Write("Enter x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Enter y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Enter x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Enter y2: ");
            double y2 = double.Parse(Console.ReadLine());
            double distance = FindEuclideanDistance(x1, y1, x2, y2);
            Console.WriteLine($"\nEuclidean Distance = {distance:F2}");
            if (x1 == x2)
            {
                Console.WriteLine("Equation of Line: x = " + x1);
            }
            else
            {
                double[] equation = FindLineEquation(x1, y1, x2, y2);
                Console.WriteLine($"Slope (m) = {equation[0]:F2}");
                Console.WriteLine($"Y-Intercept (b) = {equation[1]:F2}");
                Console.WriteLine($"Equation of Line: y = {equation[0]:F2}x + {equation[1]:F2}");
            }
        }

        public static double FindEuclideanDistance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
        {
            double slope = (y2 - y1) / (x2 - x1);
            double intercept = y1 - (slope * x1);
            return new double[] { slope, intercept };
        }
    }
}