using System;
namespace PracticeProblems
{
    internal class NumberAnalysis
    {
        public static void Run()
        {
            int[] numbers = new int[5];
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter the {i + 1} number: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nResult:");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        Console.WriteLine($"The number {numbers[i]} is Positive and Even.");
                    } else
                    {
                        Console.WriteLine($"The number {numbers[i]} is Positive and Odd.");
                    }
                } else
                {
                    if (numbers[i] < 0)
                    {
                        Console.WriteLine($"The number { numbers[i]} is Negative.");
                    } else
                    {
                        Console.WriteLine($"The number {numbers[i]} is zero.");
                    }
                } 
            }
        }
    }
}