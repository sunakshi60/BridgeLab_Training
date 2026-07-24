using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal class TryParseDemo
    {
        public static void CheckTryParse()
        {
            Console.WriteLine("===== TRYPARSE DEMO =====");

            Console.Write("Enter an integer: ");

            string input = Console.ReadLine();

            bool status = int.TryParse(input, out int number);

            if (status)
            {
                Console.WriteLine("Valid Integer");
                Console.WriteLine($"Number = {number}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
