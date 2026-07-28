using System;

namespace PracticeQues
{
    internal static class StudentScoreCard
    {
        public static void Run()
        {
            Console.Write("Enter number of students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());
            int[,] scores = GenerateScores(numberOfStudents);
            double[,] result = CalculateResult(scores);
            DisplayScoreCard(scores, result);
        }

        public static int[,] GenerateScores(int numberOfStudents)
        {
            Random random = new Random();
            int[,] scores = new int[numberOfStudents, 3];
            for (int i = 0; i < numberOfStudents; i++)
            {
                scores[i, 0] = random.Next(10, 100); // Physics
                scores[i, 1] = random.Next(10, 100); // Chemistry
                scores[i, 2] = random.Next(10, 100); // Maths
            }
            return scores;
        }

        public static double[,] CalculateResult(int[,] scores)
        {
            int students = scores.GetLength(0);
            double[,] result = new double[students, 3];
            for (int i = 0; i < students; i++)
            {
                double total = scores[i, 0] + scores[i, 1] + scores[i, 2];
                double average = total / 3;
                double percentage = (total / 300) * 100;
                result[i, 0] = Math.Round(total, 2);
                result[i, 1] = Math.Round(average, 2);
                result[i, 2] = Math.Round(percentage, 2);
            }
            return result;
        }

        public static void DisplayScoreCard(int[,] scores, double[,] result)
        {
            Console.WriteLine();
            Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
            for (int i = 0; i < scores.GetLength(0); i++)
            {
                Console.WriteLine($"{i + 1}\t{scores[i, 0]}\t{scores[i, 1]}\t\t{scores[i, 2]}\t{result[i, 0]}\t{result[i, 1]}\t{result[i, 2]}%");
            }
        }
    }
}