using System;

namespace BinarySearchProblems
{
    public class FirstLastOccurrence
    {
        public static void FindOccurrences()
        {
            int[] numbers = { 1, 2, 2, 2, 3, 4, 5 };

            Console.Write("Enter target: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int first = FindFirst(numbers, target);
            int last = FindLast(numbers, target);

            if (first == -1)
            {
                Console.WriteLine("Element not found.");
            }
            else
            {
                Console.WriteLine($"First occurrence: {first}");
                Console.WriteLine($"Last occurrence: {last}");
            }
        }

        private static int FindFirst(int[] numbers, int target)
        {
            int low = 0;
            int high = numbers.Length - 1;
            int result = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (numbers[mid] == target)
                {
                    result = mid;
                    high = mid - 1;
                }
                else if (numbers[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return result;
        }

        private static int FindLast(int[] numbers, int target)
        {
            int low = 0;
            int high = numbers.Length - 1;
            int result = -1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (numbers[mid] == target)
                {
                    result = mid;
                    low = mid + 1;
                }
                else if (numbers[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return result;
        }
    }
}