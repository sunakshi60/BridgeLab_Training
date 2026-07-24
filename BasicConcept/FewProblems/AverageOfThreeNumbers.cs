using System;

namespace FewProblems
{
    internal static class AverageOfThreeNumbers
    {
        public static void Run()
        {
            Console.Write("Enter First Number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.Write("Enter Third Number: ");
            double number3 = double.Parse(Console.ReadLine());

            double average = (number1 + number2 + number3) / 3;

            Console.WriteLine($"Average of the three numbers is {average:F2}");
        }
    }
}