using System;

namespace PracticeQues
{
    internal static class NumberCheckerPart2
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int[] digits = StoreDigits(number);
            Console.Write("Digits: ");
            foreach (int digit in digits)
            {
                Console.Write(digit + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum of Digits = {FindSumOfDigits(digits)}");
            Console.WriteLine($"Sum of Squares of Digits = {FindSumOfSquares(digits)}");
            Console.WriteLine($"Harshad Number = {IsHarshadNumber(number, digits)}");
            int[,] frequency = FindDigitFrequency(digits);
            Console.WriteLine("\nDigit\tFrequency");
            for (int i = 0; i < 10; i++)
            {
                if (frequency[i, 1] > 0)
                {
                    Console.WriteLine($"{frequency[i, 0]}\t{frequency[i, 1]}");
                }
            }
        }

        public static int CountDigits(int number)
        {
            number = Math.Abs(number);
            if (number == 0)
                return 1;
            int count = 0;
            while (number > 0)
            {
                count++;
                number /= 10;
            }
            return count;
        }

        public static int[] StoreDigits(int number)
        {
            number = Math.Abs(number);
            int count = CountDigits(number);
            int[] digits = new int[count];
            for (int i = count - 1; i >= 0; i--)
            {
                digits[i] = number % 10;
                number /= 10;
            }
            return digits;
        }

        public static int FindSumOfDigits(int[] digits)
        {
            int sum = 0;
           foreach (int digit in digits)
            {
                sum += digit;
            }
            return sum;
        }

        public static double FindSumOfSquares(int[] digits)
        {
            double sum = 0;
            foreach (int digit in digits)
            {
                sum += Math.Pow(digit, 2);
            }
            return sum;
        }

        public static bool IsHarshadNumber(int number, int[] digits)
        {
            int sum = FindSumOfDigits(digits);
            if (sum == 0)
                return false;
            return number % sum == 0;
        }

        public static int[,] FindDigitFrequency(int[] digits)
        {
            int[,] frequency = new int[10, 2];
            for (int i = 0; i < 10; i++)
            {
                frequency[i, 0] = i;
            }
            foreach (int digit in digits)
            {
                frequency[digit, 1]++;
            }
            return frequency;
        }
    }
}