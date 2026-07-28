using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal class PositiveNegativeOrZero
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int result = CheckNumber(number);

            if (result == 1)
            {
                Console.WriteLine("The number is Positive.");
            }
            else if (result == -1)
            {
                Console.WriteLine("The number is Negative.");
            }
            else
            {
                Console.WriteLine("The number is Zero.");
            }
        }
        public static int CheckNumber(int number)
        {
            if (number > 0)
            {
                return 1;
            }
            else if (number < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
