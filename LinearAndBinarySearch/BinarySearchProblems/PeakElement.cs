using System;

namespace BinarySearchProblems
{
    public class PeakElement
    {
        public static void FindPeak()
        {
            int[] numbers = { 1, 3, 5, 7, 6, 4, 2 };

            int low = 0;
            int high = numbers.Length - 1;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

                if (numbers[mid] < numbers[mid + 1])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            Console.WriteLine($"Peak element: {numbers[low]}");
            Console.WriteLine($"Peak index: {low}");
        }
    }
}