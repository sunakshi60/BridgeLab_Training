using System;
using System.Diagnostics;

namespace ProblemsStatements
{
    public class SortingPerformance
    {
        public static void Run()
        {
            int[] sizes = { 1000, 10000, 100000, 1000000 };

            Console.WriteLine(
                "{0,-15}{1,-25}{2,-25}{3,-25}",
                "Dataset Size",
                "Bubble Sort",
                "Merge Sort",
                "Quick Sort"
            );

            Console.WriteLine(new string('-', 90));

            foreach (int size in sizes)
            {
                int[] original = GenerateRandomArray(size);

                if (size <= 10000)
                {
                    int[] bubbleArray = (int[])original.Clone();

                    Stopwatch bubbleWatch = Stopwatch.StartNew();

                    BubbleSort(bubbleArray);

                    bubbleWatch.Stop();

                    Console.WriteLine(
                        "{0,-15}{1,-25}{2,-25}{3,-25}",
                        size,
                        bubbleWatch.Elapsed.TotalMilliseconds + " ms",
                        "",
                        ""
                    );
                }
                else
                {
                    Console.WriteLine(
                        "{0,-15}{1,-25}{2,-25}{3,-25}",
                        size,
                        "Skipped",
                        "",
                        ""
                    );
                }

                int[] mergeArray = (int[])original.Clone();

                Stopwatch mergeWatch = Stopwatch.StartNew();

                MergeSort(mergeArray, 0, mergeArray.Length - 1);

                mergeWatch.Stop();

                int[] quickArray = (int[])original.Clone();

                Stopwatch quickWatch = Stopwatch.StartNew();

                QuickSort(quickArray, 0, quickArray.Length - 1);

                quickWatch.Stop();

                Console.WriteLine(
                    "{0,-15}{1,-25}{2,-25}{3,-25}",
                    "",
                    "",
                    mergeWatch.Elapsed.TotalMilliseconds + " ms",
                    quickWatch.Elapsed.TotalMilliseconds + " ms"
                );

                Console.WriteLine();
            }
        }

        private static int[] GenerateRandomArray(int size)
        {
            Random random = new Random(42);

            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(1, 1000000);
            }

            return numbers;
        }

        private static void BubbleSort(int[] numbers)
        {
            int n = numbers.Length;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    break;
                }
            }
        }

        private static void MergeSort(
            int[] numbers,
            int left,
            int right)
        {
            if (left >= right)
            {
                return;
            }

            int middle = left + (right - left) / 2;

            MergeSort(numbers, left, middle);
            MergeSort(numbers, middle + 1, right);

            Merge(numbers, left, middle, right);
        }

        private static void Merge(
            int[] numbers,
            int left,
            int middle,
            int right)
        {
            int leftSize = middle - left + 1;
            int rightSize = right - middle;

            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            for (int i = 0; i < leftSize; i++)
            {
                leftArray[i] = numbers[left + i];
            }

            for (int j = 0; j < rightSize; j++)
            {
                rightArray[j] = numbers[middle + 1 + j];
            }

            int x = 0;
            int y = 0;
            int k = left;

            while (x < leftSize && y < rightSize)
            {
                if (leftArray[x] <= rightArray[y])
                {
                    numbers[k] = leftArray[x];
                    x++;
                }
                else
                {
                    numbers[k] = rightArray[y];
                    y++;
                }

                k++;
            }

            while (x < leftSize)
            {
                numbers[k] = leftArray[x];
                x++;
                k++;
            }

            while (y < rightSize)
            {
                numbers[k] = rightArray[y];
                y++;
                k++;
            }
        }

        private static void QuickSort(
            int[] numbers,
            int low,
            int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(numbers, low, high);

                QuickSort(numbers, low, pivotIndex - 1);
                QuickSort(numbers, pivotIndex + 1, high);
            }
        }

        private static int Partition(
            int[] numbers,
            int low,
            int high)
        {
            int pivot = numbers[high];

            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (numbers[j] <= pivot)
                {
                    i++;

                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }

            int lastTemp = numbers[i + 1];
            numbers[i + 1] = numbers[high];
            numbers[high] = lastTemp;

            return i + 1;
        }
    }
}