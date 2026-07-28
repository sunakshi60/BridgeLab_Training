using System;

namespace PracticeProblems
{
    internal static class PositiveNegativeEvenOdd
    {
        public static void Run()
        {
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            foreach (int number in numbers)
            {
                if (IsPositive(number))
                {
                    Console.Write($"{number} is Positive");

                    if (IsEven(number))
                    {
                        Console.WriteLine(" and Even.");
                    }
                    else
                    {
                        Console.WriteLine(" and Odd.");
                    }
                }
                else
                {
                    Console.WriteLine($"{number} is Negative.");
                }
            }

            int result = Compare(numbers[0], numbers[numbers.Length - 1]);

            if (result == 1)
            {
                Console.WriteLine("\nFirst number is Greater than Last number.");
            }
            else if (result == 0)
            {
                Console.WriteLine("\nFirst number is Equal to Last number.");
            }
            else
            {
                Console.WriteLine("\nFirst number is Less than Last number.");
            }
        }

        public static bool IsPositive(int number)
        {
            return number >= 0;
        }
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static int Compare(int number1, int number2)
        {
            if (number1 > number2)
                return 1;
            if (number1 == number2)
                return 0;

            return -1;
        }
    }
}