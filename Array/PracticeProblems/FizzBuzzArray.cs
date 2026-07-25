using System;

namespace PracticeProblems
{
    internal class FizzBuzzArray
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
                return;
            }

            string[] result = new string[number + 1];

            for (int i = 0; i <= number; i++)
            {
                if (i == 0)
                {
                    result[i] = "0";
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    result[i] = "FizzBuzz";
                }
                else if (i % 3 == 0)
                {
                    result[i] = "Fizz";
                }
                else if (i % 5 == 0)
                {
                    result[i] = "Buzz";
                }
                else
                {
                    result[i] = i.ToString();
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Position {i} = {result[i]}");
            }
        }
    }
}