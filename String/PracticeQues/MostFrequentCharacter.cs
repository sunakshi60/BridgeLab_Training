using System;

namespace PracticeQues
{
    internal static class MostFrequentCharacter
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            char result = FindMostFrequent(text);
            Console.WriteLine("Most Frequent Character: " + result);
        }

        private static char FindMostFrequent(string str)
        {
            int maxCount = 0;
            char frequent = str[0];
            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                        count++;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    frequent = str[i];
                }
            }
            return frequent;
        }
    }
}