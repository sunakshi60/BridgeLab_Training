using System;

namespace ControlFlowPracticeProblems
{
    internal static class HarshadNumberChecker
    {
        public static void Run()
        {
            Console.Write("Enter a Number: ");
            int number = int.Parse(Console.ReadLine());

            int temp = number;
            int sum = 0;

            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            if (number % sum == 0)
                Console.WriteLine($"{number} is a Harshad Number.");
            else
                Console.WriteLine($"{number} is not a Harshad Number.");
        }
    }
}