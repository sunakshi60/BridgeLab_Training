using System;

namespace PracticeProblems
{
    internal static class DigitFrequency
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            long number = long.Parse(Console.ReadLine());

            if (number < 0)
            {
                number = -number;
            }

            long temp = number;
            int digitCount = 0;

            if (number == 0)
            {
                digitCount = 1;
            }
            else
            {
                while (temp != 0)
                {
                    digitCount++;
                    temp /= 10;
                }
            }

            int[] digits = new int[digitCount];
            int[] frequency = new int[10];

            temp = number;

            if (number == 0)
            {
                digits[0] = 0;
                frequency[0]++;
            }
            else
            {
                for (int i = digitCount - 1; i >= 0; i--)
                {
                    digits[i] = (int)(temp % 10);
                    temp /= 10;
                }

                for (int i = 0; i < digitCount; i++)
                {
                    frequency[digits[i]]++;
                }
            }

            Console.WriteLine("\nDigit Frequencies:");

            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] > 0)
                {
                    Console.WriteLine($"Digit {i} = {frequency[i]}");
                }
            }
        }
    }
}