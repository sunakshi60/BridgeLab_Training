using System;

namespace Level2PracticeQues
{
    internal static class NumberSwapper
    {
        public static void Run()
        {
            Console.Write("Enter First Number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            int number2 = int.Parse(Console.ReadLine());

            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine($"The swapped numbers are {number1} and {number2}");
        }
    }
}