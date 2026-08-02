using System;

namespace ScenerioBasedStringAssignment
{
    internal class ParagraphAnalyzer
    {
        public static void Run()
        {
            Console.Write("Enter paragraph: ");
            string text = Console.ReadLine();

            CountWords(text);
            FindLongestWord(text);
            ReplaceWord(text);
        }

        static void CountWords(string text)
        {
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Word Count : " + words.Length);
        }

        static void FindLongestWord(string text)
        {
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' },
            StringSplitOptions.RemoveEmptyEntries);
            string longest = "";
            foreach (string word in words)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }
            Console.WriteLine("Longest Word : " + longest);
        }

        static void ReplaceWord(string text)
        {
            Console.Write("Enter word to replace: ");
            string oldWord = Console.ReadLine();
            Console.Write("Enter new word: ");
            string newWord = Console.ReadLine();
            string result = text.Replace(oldWord, newWord, StringComparison.OrdinalIgnoreCase);
            Console.WriteLine("\nUpdated Paragraph:");
            Console.WriteLine(result);
        }
    }
}