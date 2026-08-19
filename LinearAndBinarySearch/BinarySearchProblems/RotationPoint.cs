using System;

namespace BinarySearchProblems
{
    public class RotationPoint
    {
        public static void FindRotationPoint()
        {
            int[] numbers = { 4, 5, 6, 7, 1, 2, 3 };

            int low = 0;
            int high = numbers.Length - 1;

            while (low < high)
            {
                int mid = low + (high - low) / 2;

                if (numbers[mid] > numbers[high])
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid;
                }
            }

            Console.WriteLine($"Smallest element: {numbers[low]}");
            Console.WriteLine($"Rotation point index: {low}");
        }
    }
}