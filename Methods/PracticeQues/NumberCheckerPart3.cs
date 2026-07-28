using System;

namespace PracticeQues
{
    internal static class NumberCheckerPart3
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int[] digits = StoreDigits(number);
            int[] reversedDigits = ReverseDigits(digits);
            Console.Write("Original Digits: ");
            foreach (int digit in digits)
            {
                Console.Write(digit + " ");
            }
            Console.WriteLine();
            Console.Write("Reversed Digits: ");
            foreach (int digit in reversedDigits)
            {
                Console.Write(digit + " ");
            }
            Console.WriteLine();

            Console.WriteLine($"Arrays Equal = {CompareArrays(digits, reversedDigits)}");
            Console.WriteLine($"Palindrome Number = {IsPalindrome(digits)}");
            Console.WriteLine($"Duck Number = {IsDuckNumber(digits)}");
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

        public static int[] ReverseDigits(int[] digits)
        {
            int[] reversed = new int[digits.Length];
            for (int i = 0; i < digits.Length; i++)
            {
                reversed[i] = digits[digits.Length - 1 - i];
            }
            return reversed;
        }

        public static bool CompareArrays(int[] firstArray, int[] secondArray)
        {
            if (firstArray.Length != secondArray.Length)
            {
                return false;
            }
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPalindrome(int[] digits)
        {
            int[] reversed = ReverseDigits(digits);
            return CompareArrays(digits, reversed);
        }

        public static bool IsDuckNumber(int[] digits)
        {
            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}