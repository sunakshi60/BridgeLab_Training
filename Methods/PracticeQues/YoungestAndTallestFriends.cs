using System;

namespace PracticeProblems
{
    internal static class YoungestAndTallestFriends
    {
        public static void Run()
        {
            string[] names = { "Amar", "Akbar", "Anthony" };

            int[] ages = new int[3];
            double[] heights = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter age of {names[i]}: ");
                ages[i] = int.Parse(Console.ReadLine());
                Console.Write($"Enter height of {names[i]} (in cm): ");
                heights[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Youngest Friend: {FindYoungest(names, ages)}");
            Console.WriteLine($"Tallest Friend: {FindTallest(names, heights)}");
        }

        public static string FindYoungest(string[] names, int[] ages)
        {
            int index = 0;
            for (int i = 1; i < ages.Length; i++)
            {
                if (ages[i] < ages[index])
                {
                    index = i;
                }
            }
            return names[index];
        }

        public static string FindTallest(string[] names, double[] heights)
        {
            int index = 0;
            for (int i = 1; i < heights.Length; i++)
            {
                if (heights[i] > heights[index])
                {
                    index = i;
                }
            }
            return names[index];
        }
    }
}