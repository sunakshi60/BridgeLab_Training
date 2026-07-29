using System;

namespace Level1
{
    internal static class SubstringUsingCharAt
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            Console.Write("Enter start index: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end index: ");
            int end = Convert.ToInt32(Console.ReadLine());
            string custom = CreateSubstring(text, start, end);
            string builtin = text.Substring(start, end - start + 1);
            Console.WriteLine("Custom Substring : " + custom);
            Console.WriteLine("Built-in Substring: " + builtin);
        }

        private static string CreateSubstring(string str, int start, int end)
        {
            string result = "";
            for (int i = start; i <= end; i++)
            {
                result += str[i];
            }
            return result;
        }
    }
}