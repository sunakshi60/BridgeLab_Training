using System;

namespace Level2PracticeQues
{
    internal static class DoubleOperations
    {
        public static void Run()
        {
            Console.Write("Enter a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter c: ");
            double c = double.Parse(Console.ReadLine());

            double result1 = a + b * c;
            double result2 = a * b + c;
            double result3 = c + a / b;
            double result4 = a % b + c;

            Console.WriteLine($"The results of Double Operations are {result1}, {result2}, {result3}, {result4}");
        }
    }
}