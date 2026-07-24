using System;

namespace FewProblems
{
    internal static class AddTwoNumbers
    {
        public static void Run()
        {
            Console.Write("Enter First Number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double number2 = double.Parse(Console.ReadLine());

            double sum = number1 + number2;

            Console.WriteLine($"The sum of {number1} + {number2} is {sum}");
        }
    }
}