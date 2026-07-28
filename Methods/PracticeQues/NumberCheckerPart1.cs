using System;

namespace PracticeQues
{
    internal static class NumberCheckerPart1
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
            Console.WriteLine($"Digit Count = {CountDigits(number)}");
            Console.WriteLine($"Duck Number = {IsDuckNumber(digits)}");
            Console.WriteLine($"Armstrong Number = {IsArmstrongNumber(number, digits)}");
            int[] largest = FindLargestAndSecondLargest(digits);
            Console.WriteLine($"Largest Digit = {largest[0]}");
            Console.WriteLine($"Second Largest Digit = {largest[1]}");
            int[] smallest = FindSmallestAndSecondSmallest(digits);
            Console.WriteLine($"Smallest Digit = {smallest[0]}");
            Console.WriteLine($"Second Smallest Digit = {smallest[1]}");
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

        public static bool IsDuckNumber(int[] digits)
        {
            for (int i = 1; i < digits.Length; i++)
            {
                if (digits[i] == 0)
                    return true;
            }
            return false;
        }

        public static bool IsArmstrongNumber(int number, int[] digits)
        {
            int sum = 0;
            foreach (int digit in digits)
            {
                sum += (int)Math.Pow(digit, digits.Length);
            }
            return sum == Math.Abs(number);
        }

        public static int[] FindLargestAndSecondLargest(int[] digits)
        {
            int largest = int.MinValue;
            int secondLargest = int.MinValue;
            foreach (int digit in digits)
            {
                if (digit > largest)
                {
                    secondLargest = largest;
                    largest = digit;
                }
                else if (digit > secondLargest && digit != largest)
                {
                    secondLargest = digit;
                }
            }
            return new int[] { largest, secondLargest };
        }

        public static int[] FindSmallestAndSecondSmallest(int[] digits)
        {
            int smallest = int.MaxValue;
            int secondSmallest = int.MaxValue;
            foreach (int digit in digits)
            {
                if (digit < smallest)
                {
                    secondSmallest = smallest;
                    smallest = digit;
                }
                else if (digit < secondSmallest && digit != smallest)
                {
                    secondSmallest = digit;
                }
            }
            return new int[] { smallest, secondSmallest };
        }
    }
}