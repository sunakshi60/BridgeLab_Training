using System;

namespace PracticeQues
{
    internal static class SquareSideCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Perimeter of Square: ");
            double perimeter = double.Parse(Console.ReadLine());

            double side = perimeter / 4;

            Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
        }
    }
}