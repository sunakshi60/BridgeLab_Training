using System;

public class SearchWordInSentences
{
    public static void Search()
    {
        string[] sentences =
        {
            "I am learning CSharp programming.",
            "Linear Search is easy to understand.",
            "I practice algorithms every day.",
            "CSharp has many useful features.",
            "Searching algorithms are important."
        };

        Console.Write("Enter the word to search: ");
        string word = Console.ReadLine() ?? "";

        for (int i = 0; i < sentences.Length; i++)
        {
            if (sentences[i].Contains(word, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Word found in sentence: {sentences[i]}");
                Console.WriteLine($"Found at index: {i}");
                return;
            }
        }

        Console.WriteLine("Word not found in any sentence.");
    }
}