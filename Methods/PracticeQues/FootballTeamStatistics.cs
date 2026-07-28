using System;

namespace PracticeQues
{
    internal static class FootballTeamStatistics
    {
        public static void Run()
        {
            int[] heights = GenerateHeights(11);
            Console.WriteLine("Player Heights (cm):");
            foreach (int height in heights)
            {
                Console.Write(height + " ");
            }
            Console.WriteLine();
            int sum = FindSum(heights);
            double mean = FindMean(heights);
            int shortest = FindShortest(heights);
            int tallest = FindTallest(heights);
            Console.WriteLine($"\nSum of Heights = {sum}");
            Console.WriteLine($"Mean Height = {mean:F2}");
            Console.WriteLine($"Shortest Height = {shortest} cm");
            Console.WriteLine($"Tallest Height = {tallest} cm");
        }

        public static int[] GenerateHeights(int size)
        {
            Random random = new Random();
            int[] heights = new int[size];
            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = random.Next(150, 251);
            }
            return heights;
        }

        public static int FindSum(int[] heights)
        {
            int sum = 0;
            foreach (int height in heights)
            {
                sum += height;
            }
            return sum;
        }

        public static double FindMean(int[] heights)
        {
            return (double)FindSum(heights) / heights.Length;
        }

        public static int FindShortest(int[] heights)
        {
            int shortest = heights[0];
            foreach (int height in heights)
            {
                if (height < shortest)
                {
                    shortest = height;
                }
            }
            return shortest;
        }

        public static int FindTallest(int[] heights)
        {
            int tallest = heights[0];
            foreach (int height in heights)
            {
                if (height > tallest)
                {
                    tallest = height;
                }
            }
            return tallest;
        }
    }
}