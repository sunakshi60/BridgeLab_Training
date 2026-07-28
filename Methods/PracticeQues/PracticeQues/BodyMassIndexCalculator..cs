using System;

namespace PracticeProblems
{
    internal static class BodyMassIndexCalculator
    {
        public static void Run()
        {
            double[,] persons = new double[10, 3];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter weight of Person {i + 1} (kg): ");
                persons[i, 0] = double.Parse(Console.ReadLine());
                Console.Write($"Enter height of Person {i + 1} (cm): ");
                persons[i, 1] = double.Parse(Console.ReadLine());
                persons[i, 2] = CalculateBMI(persons[i, 0], persons[i, 1]);
            }
            Console.WriteLine("\nWeight\tHeight\tBMI\tStatus");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{persons[i, 0]}\t{persons[i, 1]}\t{persons[i, 2]:F2}\t{GetBMIStatus(persons[i, 2])}");
            }
        }

        public static double CalculateBMI(double weight, double height)
        {
            double heightInMeters = height / 100;
            return weight / (heightInMeters * heightInMeters);
        }

        public static string GetBMIStatus(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi < 25)
                return "Normal";
            else if (bmi < 30)
                return "Overweight";
            else
                return "Obese";
        }
    }
}