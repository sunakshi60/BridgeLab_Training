using System;


namespace ScenerioBasedQues
{
    class Program
    {
        static void Main(string[] args)
        {
            //    float[,] temperatures =
            //{
            //    {30,31,29,28,27,26,27,29,31,33,35,36,37,38,37,36,35,34,33,32,31,30,29,28},
            //    {28,29,28,27,26,25,26,28,30,32,34,35,36,37,36,35,34,33,32,31,30,29,28,27},
            //    {32,33,32,31,30,29,30,32,34,36,38,39,40,41,40,39,38,37,36,35,34,33,32,31},
            //    {25,26,25,24,23,22,23,24,26,28,30,31,32,33,32,31,30,29,28,27,26,25,24,23},
            //    {31,32,31,30,29,28,29,31,33,35,37,38,39,40,39,38,37,36,35,34,33,32,31,30},
            //    {27,28,27,26,25,24,25,27,29,31,33,34,35,36,35,34,33,32,31,30,29,28,27,26},
            //    {29,30,29,28,27,26,27,29,31,33,35,36,37,38,37,36,35,34,33,32,31,30,29,28}
            //};

            //    TemperatureAnalyzer.AnalyzeTemperature(temperatures);

            //StudentScoreAnalyzer.AnalyzeScores();

            //Book[] books =
            //{
            //    new Book("The Alchemist", "Paulo Coelho", "Available"),
            //    new Book("Harry Potter", "J.K. Rowling", "Checked Out"),
            //    new Book("Clean Code", "Robert Martin", "Available"),
            //    new Book("The Great Gatsby", "F. Scott Fitzgerald", "Available")
            //};
            //Library library = new Library(books);
            //Console.WriteLine("All Books:");
            //library.DisplayBooks();
            //Console.WriteLine("\nSearch Result:");
            //library.SearchBook("Harry");
            //Console.WriteLine("\nUpdating Book Status:");
            //library.UpdateBookStatus("The Alchemist", "Checked Out");
            //Console.WriteLine("\nUpdated Books:");
            //library.DisplayBooks();


            string[] correctAnswers =
            {
                "A", "B", "C", "D", "A",
                "B", "C", "D", "A", "B"
            };
            string[] studentAnswers =
            {
                "a", "B", "C", "A", "A",
                "B", "D", "D", "A", "C"
            };
            QuizGrader quiz = new QuizGrader();
            int score = quiz.CalculateScore(correctAnswers, studentAnswers);
            Console.WriteLine("Quiz Feedback:");
            quiz.DisplayFeedback(correctAnswers, studentAnswers);
            quiz.DisplayResult(score, correctAnswers.Length);


            Console.ReadLine();
        }
    }
}
