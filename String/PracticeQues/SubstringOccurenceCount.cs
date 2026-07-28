using System;

namespace PracticeQues
{
    internal class SubstringOccurenceCounts
    {
        public static void Run()
        {
            Console.Write("Enter the main string: ");
            string text = Console.ReadLine();
            Console.Write("Enter the substring: ");
            string sub = Console.ReadLine();
            int count = CountOccurences(text, sub);
            Console.WriteLine("Occurence: " + count);
        }
        private static int CountOccurences(string text,string sub)
        {
            int count = 0;
            for(int i = 0; i <= text.Length - sub.Length; i++)
            {
                bool found = true;
                for(int j = 0; j < sub.Length; j++)
                {
                    if (text[i + j] != sub[j])
                    {
                           found = false;
                           break;
                    }
                }
                if (found)
                    count++;
            }
            return count;
        }
    }
}