using System;

namespace PracticeQues
{
    internal static class LongestWordInSentence
    {
        public static void Run()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            string longestWord = FindLongestWord(sentence);
            Console.WriteLine("Longest Word: " + longestWord);
        }

        private static string FindLongestWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            string longest = words[0];
            foreach(string word in words)
            {
                if (word.Length > longest.Length)
                {
                    longest = word;
                }
            }
            return longest;
        }
    }
}