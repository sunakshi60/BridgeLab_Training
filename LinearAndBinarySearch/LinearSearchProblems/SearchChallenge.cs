using System;

namespace LinearSearchProblems
{
    public class SearchChallenge
    {
        public static void Run()
        {
            int[] numbers = { 3, 4, -1, 1, 2, 7 };

            Console.Write("Enter target number: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int firstMissing = FindFirstMissingPositive(numbers);

            Console.WriteLine($"First missing positive integer: {firstMissing}");

            Array.Sort(numbers);

            Console.WriteLine("\nSorted Array:");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            int targetIndex = BinarySearch(numbers, target);

            Console.WriteLine(
                $"Target index after sorting: {targetIndex}"
            );
        }

        private static int FindFirstMissingPositive(int[] numbers)
        {
            int n = numbers.Length;

            bool[] visited = new bool[n + 1];

            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > 0 && numbers[i] <= n)
                {
                    visited[numbers[i]] = true;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (!visited[i])
                {
                    return i;
                }
            }

            return n + 1;
        }
        private static int BinarySearch(int[] numbers, int target)
        {
            int low = 0;
            int high = numbers.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (numbers[mid] == target)
                {
                    return mid;
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

            return -1;
        }
    }
}