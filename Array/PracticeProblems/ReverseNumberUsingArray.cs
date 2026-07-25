using System;

namespace PracticeProblems
{
    internal class ReverseNumberUsingArray
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

            while (temp != 0)
            {
                digitCount++;
                temp /= 10;
            }

            if (number == 0)
            {
                digitCount = 1;
            }

            int[] digits = new int[digitCount];
            int[] reverseDigits = new int[digitCount];

            temp = number;

            for (int i = digitCount - 1; i >= 0; i--)
            {
                digits[i] = (int)(temp % 10);
                temp /= 10;
            }

            for (int i = 0; i < digitCount; i++)
            {
                reverseDigits[i] = digits[digitCount - 1 - i];
            }

            Console.Write("\nDigits Array: ");
            for (int i = 0; i < digitCount; i++)
            {
                Console.Write(digits[i] + " ");
            }

            Console.Write("\nReversed Array: ");
            for (int i = 0; i < digitCount; i++)
            {
                Console.Write(reverseDigits[i] + " ");
            }

            Console.Write("\nReversed Number: ");
            for (int i = 0; i < digitCount; i++)
            {
                Console.Write(reverseDigits[i]);
            }

            Console.WriteLine();
        }
    }
}