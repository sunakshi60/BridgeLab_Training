using System;
using System.IO;

namespace StreamReaderProblems
{
    public class CountWordOccurrence
    {
        public static void CountWord()
        {
            string filePath = "sample.txt";
            Console.Write("Enter the word to search: ");
            string word = Console.ReadLine() ?? "";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }
            int count = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(
                        new char[] { ' ', ',', '.', '!', '?', ';', ':' },
                        StringSplitOptions.RemoveEmptyEntries
                    );
                    foreach (string currentWord in words)
                    {
                        if (currentWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine($"'{word}' occurred {count} times.");
        }
    }
}