using System;

namespace PracticeQues
{
    internal class Calculator
    {
        public static int firstNumber, secondNumber;

        public static void Accept()
        {
            Console.Write("Enter first number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());
        }

        public static void Add()
        {
            Console.WriteLine("Addition = " + (firstNumber + secondNumber));
        }

        public static void Subtract()
        {
            Console.WriteLine("Subtraction = " + (firstNumber - secondNumber));
        }

        public static void Mul()
        {
            Console.WriteLine("Multiplication = " + (firstNumber * secondNumber));
        }

        public static void Div()
        {
            if (secondNumber != 0)
                Console.WriteLine("Division = " + (firstNumber / secondNumber));
            else
                Console.WriteLine("Cannot divide by zero.");
        }
    }
}