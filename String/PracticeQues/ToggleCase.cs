using System;

namespace PracticeQues
{
    internal static class ToggleCase
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            string result = Toggle(text);
            Console.WriteLine("Modified String: " + result);
        }

        private static string Toggle(string str)
        {
            string result = "";
           foreach (char ch in str)
            {
                if (char.IsUpper(ch))
                    result += char.ToLower(ch);
                else if (char.IsLower(ch))
                    result += char.ToUpper(ch);
                else
                    result += ch;
            }
            return result;
        }
    }
}