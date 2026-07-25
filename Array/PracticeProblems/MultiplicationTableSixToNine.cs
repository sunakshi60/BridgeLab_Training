using System;

namespace PracticeProblems
{
    internal class MultiplicationTableSixToNine
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            // First Approach
            //int[] arr = new int[9];
            //for (int i = 1; i <= arr.Length; i++)
            //{
            //    arr[i - 1] = number * i;
            //}
            //for (int i = 6; i <= 9; i++)
            //{
            //    Console.WriteLine($"{number} * {i} = {arr[i - 1]}");
            //}


            // Second Approach
            int[] arr = new int[4];
            for (int i = 6; i <= 9; i++)
            {
                arr[i-6] = number * i;
            }
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {arr[i - 6]}");
            }
        }
    }
}