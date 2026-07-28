using System;

namespace PracticeProblems
{
    internal static class RandomNumbersStatistics
    {
        public static void Run()
        {
            int[] numbers = Generate4DigitRandomArray(5);
            Console.WriteLine("Generated Numbers:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            double[] result = FindAverageMinMax(numbers);
            Console.WriteLine($"\nAverage = {result[0]:F2}");
            Console.WriteLine($"Minimum = {result[1]}");
            Console.WriteLine($"Maximum = {result[2]}");
        }

        public static int[] Generate4DigitRandomArray(int size)
        {
            Random random = new Random();
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(1000, 10000);
            }
            return numbers;
        }

        public static double[] FindAverageMinMax(int[] numbers)
        {
            int sum = 0;
            int min = numbers[0];
            int max = numbers[0];
            foreach (int number in numbers)
            {
                sum += number;
                min = Math.Min(min, number);
                max = Math.Max(max, number);
            }
            double average = (double)sum / numbers.Length;
            return new double[] { average, min, max };
        }
    }
}