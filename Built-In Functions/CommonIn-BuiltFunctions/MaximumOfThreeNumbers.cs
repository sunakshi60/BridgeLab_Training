using System;

namespace CommonIn_BuiltFunctions
{
    class MaximumOfThreeNumbers
    {
        public static void Run()
        {
            int num1 = GetNumber("Enter First Number: ");
            int num2 = GetNumber("Enter Second Number: ");
            int num3 = GetNumber("Enter Third Number: ");
            int maximum = FindMaximum(num1, num2, num3);
            DisplayResult(maximum);
        }

        static int GetNumber(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int FindMaximum(int a, int b, int c)
        {
            return Math.Max(a, Math.Max(b, c));
        }

        static void DisplayResult(int max)
        {
            Console.WriteLine("Maximum Number = " + max);
        }
    }
}