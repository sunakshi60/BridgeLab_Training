using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal class SumOfNNaturalNumbers
    {
        public static void Run()
        {
            Console.Write("Enter a positive number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = FindSum(number);
            Console.WriteLine($"Sum of first {number} natural numbers = {sum}");
        }
        public static int FindSum(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
