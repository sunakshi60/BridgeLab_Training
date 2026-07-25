using System;

namespace ControlFlowPracticeProblems
{
    internal static class LargestNumber
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int number3 = int.Parse(Console.ReadLine());

            bool firstLargest = number1 > number2 && number1 > number3;
            bool secondLargest = number2 > number1 && number2 > number3;
            bool thirdLargest = number3 > number1 && number3 > number2;

            Console.WriteLine($"Is the first number the largest? {firstLargest}");
            Console.WriteLine($"Is the second number the largest? {secondLargest}");
            Console.WriteLine($"Is the third number the largest? {thirdLargest}");
        }
    }
}