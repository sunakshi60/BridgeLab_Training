using System;

namespace PracticeQues
{
    internal static class BasicCalculator
    {
        public static void Run()
        {
            Console.Write("Enter First Number: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double number2 = double.Parse(Console.ReadLine());

            double add = number1 + number2;
            double sub = number1 - number2;
            double mul = number1 * number2;
            double div = number1 / number2;

            Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {number1} and {number2} is {add}, {sub}, {mul}, and {div}");
        }
    }
}