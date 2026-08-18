using System;

namespace ScenerioBasedQues
{
    public class QuizGrader
    {
        public int CalculateScore(string[] correct, string[] student)
        {
            int score = 0;
            for (int i = 0; i < correct.Length; i++)
            {
                if (string.Equals(correct[i],student[i],StringComparison.OrdinalIgnoreCase))
                {
                    score++;
                }
            }
            return score;
        }

        public void DisplayFeedback(string[] correct, string[] student)
        {
            for (int i = 0; i < correct.Length; i++)
            {
                if (string.Equals(correct[i], student[i], StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Question {i + 1}: Correct");
                }
                else
                {
                    Console.WriteLine($"Question {i + 1}: Incorrect");
                }
            }
        }

        public void DisplayResult(int score, int totalQuestions)
        {
            double percentage = (double)score / totalQuestions * 100;
            Console.WriteLine($"\nScore: {score}/{totalQuestions}");
            Console.WriteLine($"Percentage: {percentage}%");
            if (percentage >= 40)
            {
                Console.WriteLine("Result: Pass");
            }
            else
            {
                Console.WriteLine("Result: Fail");
            }
        }
    }
}