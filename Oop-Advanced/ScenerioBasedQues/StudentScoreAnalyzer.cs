using System;

namespace ScenarioBasedQuestions
{
    public class StudentScoreAnalyzer
    {
        public static void AnalyzeScores()
        {
            Console.Write("Enter number of students: ");

            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Invalid input! Enter a positive number: ");
            }

            int[] scores = new int[n];

            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Enter score of Student {i + 1}: ");

                    if (!int.TryParse(Console.ReadLine(), out scores[i]))
                    {
                        Console.WriteLine("Invalid input! Enter a numeric value.");
                    }
                    else if (scores[i] < 0)
                    {
                        Console.WriteLine("Score cannot be negative.");
                    }
                    else
                    {
                        break;
                    }
                }
            }

            int sum = 0;
            int highest = scores[0];
            int lowest = scores[0];

            foreach (int score in scores)
            {
                sum += score;

                if (score > highest)
                    highest = score;

                if (score < lowest)
                    lowest = score;
            }

            double average = (double)sum / n;

            Console.WriteLine("\n----- Result -----");
            Console.WriteLine($"Average Score : {average:F2}");
            Console.WriteLine($"Highest Score : {highest}");
            Console.WriteLine($"Lowest Score  : {lowest}");

            Console.WriteLine("\nScores Above Average:");

            bool found = false;

            foreach (int score in scores)
            {
                if (score > average)
                {
                    Console.WriteLine(score);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No scores above average.");
            }
        }
    }
}