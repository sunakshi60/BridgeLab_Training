using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace C_Streams
{
    internal class WordCounter
    {

        public static void Run()
        {
            string fileName = "input.txt";

            try
            {
                Dictionary<string, int> wordCount = new Dictionary<string, int>();

                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] words = line
                            .ToLower()
                            .Split(
                                new char[]
                                {
                                ' ', ',', '.', '!', '?', ';', ':',
                                '"', '\'', '(', ')', '[', ']', '-'
                                },
                                StringSplitOptions.RemoveEmptyEntries);

                        foreach (string word in words)
                        {
                            if (wordCount.ContainsKey(word))
                            {
                                wordCount[word]++;
                            }
                            else
                            {
                                wordCount[word] = 1;
                            }
                        }
                    }
                }

                int totalWords = wordCount.Values.Sum();

                Console.WriteLine("Total number of words: " + totalWords);

                var topFiveWords = wordCount
                    .OrderByDescending(x => x.Value)
                    .Take(5);

                Console.WriteLine("\nTop 5 Most Frequently Occurring Words:");

                foreach (var item in topFiveWords)
                {
                    Console.WriteLine(
                        item.Key + " : " + item.Value);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Input file does not exist.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("File handling error: " + ex.Message);
            }
        }
    }
}
