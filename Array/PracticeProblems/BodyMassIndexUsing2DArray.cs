using System;

namespace PracticeProblems
{
    internal static class BodyMassIndexUsing2DArray
    {
        public static void Run()
        {
            Console.Write("Enter number of persons: ");
            int number = int.Parse(Console.ReadLine());

            double[,] personData = new double[number, 3];
            string[] weightStatus = new string[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"\nPerson {i + 1}");

                do
                {
                    Console.Write("Enter Weight (kg): ");
                    personData[i, 0] = double.Parse(Console.ReadLine());
                }
                while (personData[i, 0] <= 0);

                do
                {
                    Console.Write("Enter Height (m): ");
                    personData[i, 1] = double.Parse(Console.ReadLine());
                }
                while (personData[i, 1] <= 0);

                personData[i, 2] = personData[i, 0] /
                                   (personData[i, 1] * personData[i, 1]);

                if (personData[i, 2] < 18.5)
                    weightStatus[i] = "Underweight";
                else if (personData[i, 2] < 25)
                    weightStatus[i] = "Normal Weight";
                else if (personData[i, 2] < 30)
                    weightStatus[i] = "Overweight";
                else
                    weightStatus[i] = "Obese";
            }

            Console.WriteLine("\nWeight\tHeight\tBMI\tStatus");

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{personData[i, 0]}\t{personData[i, 1]}\t{personData[i, 2]:F2}\t{weightStatus[i]}");
            }
        }
    }
}