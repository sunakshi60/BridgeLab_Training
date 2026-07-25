using System;

namespace PracticeProblems
{
    internal class StoreNumbersAndSum
    {
        public static void Run()
        {
            double[] numbers = new double[10];
            double total = 0;
            int index = 0;

            while (true)
            {
                Console.Write("Enter a number (0 or negative to stop): ");
                double number = double.Parse(Console.ReadLine());

                if(number<=0 || index == numbers.Length)
                {
                    break;
                }
                numbers[index++] = number;
          
            }

            if (index == 0)
            {
                Console.WriteLine("\nNumber Array Contains 0 so total will be 0");

            }
            else
            {
                Console.WriteLine("\nNumbers Entered:");
            }

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numbers[i]);
                total += numbers[i];
            }

            Console.WriteLine($"\nTotal Sum = {total}");
        }
    }
}