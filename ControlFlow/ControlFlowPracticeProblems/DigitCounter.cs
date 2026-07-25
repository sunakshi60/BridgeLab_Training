using System;

namespace ControlFlowPracticeProblems
{
    internal static class DigitCounter
    {
        public static void Run()
        {
            Console.Write("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());

            int count = 0;
            int temp = Math.Abs(number);

            if (temp == 0)
            {
                count = 1;
            }
            else
            {
                while (temp != 0)
                {
                    temp /= 10;
                    count++;
                }
            }

            Console.WriteLine($"Number of Digits are = {count}");
        }
    }
}