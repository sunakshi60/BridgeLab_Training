using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal class QuotientAndRemainder
    {
        public static void Run()
        {
            Console.Write("Enter the number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the divisor: ");
            int divisor = int.Parse(Console.ReadLine());
            if (divisor == 0)
            {
                Console.WriteLine("Division by zero is not possible.");
                return;
            }
            int[] result = FindRemainderAndQuotient(number, divisor);

            Console.WriteLine($"Quotient = {result[0]}");
            Console.WriteLine($"Remainder = {result[1]}");
        }
        public static int[] FindRemainderAndQuotient(int number, int divisor)
        {
            int quotient = number / divisor;
            int remainder = number % divisor;
            return new int[] { quotient, remainder };
        }
    }
}
