using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal class ChocolateDistribution
    {
        public static void Run()
        {
            Console.Write("Enter the number of chocolates: ");
            int numberOfChocolates = int.Parse(Console.ReadLine());
            Console.Write("Enter the number of children: ");
            int numberOfChildren = int.Parse(Console.ReadLine());
            if (numberOfChildren == 0)
            {
                Console.WriteLine("Number of children cannot be zero.");
                return;
            }
            int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

            Console.WriteLine($"Each child gets {result[0]} chocolates.");
            Console.WriteLine($"Remaining chocolates = {result[1]}");
        }
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor;
            int remainder = number % divisor;
            return new int[] { quotient, remainder };
        }
    }
}
