using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal  class SwapProgram
    {
        public static int firstNumber, secondNumber;

        internal static void Accept()
        {
            Console.Write("Enter first number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            secondNumber = int.Parse(Console.ReadLine());
        }

        internal static void DisplayBeforeSwap()
        {
            Console.WriteLine($"Before Swap: First Number = {firstNumber}, Second Number = {secondNumber}");
        }

        internal static void SwapNumbers()
        {
            int temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }

        internal static void DisplayAfterSwap()
        {
            Console.WriteLine($"After Swap: First Number = {firstNumber}, Second Number = {secondNumber}");
        }
    }
}
