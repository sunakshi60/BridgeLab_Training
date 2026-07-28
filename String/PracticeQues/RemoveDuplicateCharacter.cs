using System;

namespace PracticeQues
{
    internal class RemoveDuplicateCharacter
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            string result = RemoveDuplicates(text);
            Console.WriteLine("Modified String: " + result);
        }
        private static string RemoveDuplicates(string str)
        {
            string result = "";
            foreach(char ch in str)
            {
                if (!result.Contains(ch))
                {
                    result += ch;
                }
            }
            return result;
        }
    }
}