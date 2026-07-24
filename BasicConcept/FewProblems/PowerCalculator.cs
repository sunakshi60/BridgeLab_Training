using System;

namespace FewProblems
{
    internal static class PowerCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Base: ");
            double baseNumber = double.Parse(Console.ReadLine());

            Console.Write("Enter Exponent: ");
            double exponent = double.Parse(Console.ReadLine());

            double result = Math.Pow(baseNumber, exponent);

            Console.WriteLine($"So, {baseNumber} raised to the power {exponent} is {result}");
        }
    }
}