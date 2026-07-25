using System;

namespace ControlFlowPracticeProblems
{
    internal static class SmallestNumber
    {
        public static void Run()
        {
            Console.Write("Enter first number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int number2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int number3 = int.Parse(Console.ReadLine());

            bool isSmallest = number1 < number2 && number1 < number3;

            Console.WriteLine($"Is the first number the smallest? {isSmallest}");
        }
    }
}