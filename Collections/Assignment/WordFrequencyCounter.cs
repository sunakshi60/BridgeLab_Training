using System;
using System.Collections.Generic;
using System.IO;

public class WordFrequencyCounter
{
    public static Dictionary<string, int> Solve(string filePath)
    {
        Dictionary<string, int> frequency =new Dictionary<string, int>();
        string text = File.ReadAllText(filePath);
        string[] words = text
            .ToLower()
            .Split(
                new char[] { ' ', ',', '.', '!', '?', ';', ':' },
                StringSplitOptions.RemoveEmptyEntries
            );

        foreach (string word in words)
        {
            if (frequency.ContainsKey(word))
            {
                frequency[word]++;
            }
            else
            {
                frequency.Add(word, 1);
            }
        }
        return frequency;
    }
}