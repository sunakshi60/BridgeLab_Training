using System;

namespace PracticeProblems
{
    internal class FactorsOfNumber
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Please enter a positive number.");
            }

            int maxFactor = 10;
            int[] factors = new int[maxFactor];
            int index = 0;

           for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (index == maxFactor)
                    {
                        maxFactor *= 2;

                        int[] temp = new int[maxFactor];
                        for (int j = 0; j < factors.Length; j++)
                        {
                            temp[j] = factors[j];
                        }
                        factors = temp;
                    }
                    factors[index++] = i;
                }
            }
            Console.Write($"The factor of {number} are: ");
            for(int i = 0; i < index; i++)
            {
                Console.Write(factors[i] + " ");
            }
        }
    }
}
