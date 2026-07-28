using System;

namespace PracticeQues
{
    internal static class ReplaceWordInSentence
    {
        public static void Run()
        {
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            Console.Write("Enter word to replace: ");
            string oldWord = Console.ReadLine();
            Console.Write("Enter new word: ");
            string newWord = Console.ReadLine();
            string result = ReplaceWord(sentence, oldWord, newWord);
            Console.WriteLine("Modified Sentence:");
            Console.WriteLine(result);
        }

        private static string ReplaceWord(string sentence, string oldWord, string newWord)
        {
            string[] words = sentence.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == oldWord)
                {
                    words[i] = newWord;
                }
            }
            return string.Join(" ", words);
        }
    }
}