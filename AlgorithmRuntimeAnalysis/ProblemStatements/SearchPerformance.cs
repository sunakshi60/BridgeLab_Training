using System;
using System.Diagnostics;

namespace ProblemsStatements
{
    public class SearchPerformance
    {
        public static void Run()
        {
            int[] sizes = { 1000, 10000, 100000, 1000000 };

            Console.WriteLine(
                "{0,-15}{1,-25}{2,-25}",
                "Dataset Size",
                "Linear Search",
                "Binary Search"
            );

            Console.WriteLine(new string('-', 65));

            foreach (int size in sizes)
            {
                int[] numbers = new int[size];

                for (int i = 0; i < size; i++)
                {
                    numbers[i] = i + 1;
                }

                int target = size;  

                Stopwatch linearWatch = Stopwatch.StartNew();

                int linearIndex = LinearSearch(numbers, target);

                linearWatch.Stop();

                Stopwatch binaryWatch = Stopwatch.StartNew();

                int binaryIndex = BinarySearch(numbers, target);

                binaryWatch.Stop();

                Console.WriteLine(
                    "{0,-15}{1,-25}{2,-25}",
                    size,
                    linearWatch.Elapsed.TotalMilliseconds + " ms",
                    binaryWatch.Elapsed.TotalMilliseconds + " ms"
                );
            }
        }

        private static int LinearSearch(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    return i;
                }
            }

            return -1;
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