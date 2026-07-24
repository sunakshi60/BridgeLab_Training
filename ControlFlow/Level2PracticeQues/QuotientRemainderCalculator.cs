using System;

namespace Level2PracticeQues
{
    internal static class QuotientRemainderCalculator
    {
        public static void Run()
        {
            Console.Write("Enter First Number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int number2 = int.Parse(Console.ReadLine());

            int quotient = number1 / number2;
            int remainder = number1 % number2;

            Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}");
        }
    }
}