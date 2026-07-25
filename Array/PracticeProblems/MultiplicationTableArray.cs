using System;

namespace PracticeProblems
{
    internal class MultiplicationTableArray
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int[] table = new int[10];
            for(int i = 1; i <=10; i++)
            {
                table[i - 1] =number* i;
            }
            Console.WriteLine("\nMultiplication Table:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {table[i-1]}");
            }
        }
    }
}