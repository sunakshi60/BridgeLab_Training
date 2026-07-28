using System;

namespace PracticeQues
{
    internal static class RemoveSpecificCharacter
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            Console.Write("Enter character to remove: ");
            char ch = Convert.ToChar(Console.ReadLine());
            string result = RemoveCharacter(text, ch);
            Console.WriteLine("Modified String: " + result);
        }

        private static string RemoveCharacter(string str, char ch)
        {
            string result = "";
            foreach (char c in str)
            {
                if (c != ch)
                {
                    result += c;
                }
            }
            return result;
        }
    }
}