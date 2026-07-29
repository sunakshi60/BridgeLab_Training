using System;

namespace CommonIn_BuiltFunctions
{
    class PalindromeChecker
    {
        public static void Run()
        {
            string text = GetInput();
            bool result = IsPalindrome(text);
            DisplayResult(result);
        }

        static string GetInput()
        {
            Console.Write("Enter a String: ");
            return Console.ReadLine();
        }

        static bool IsPalindrome(string text)
        {
            string reverse = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverse += text[i];
            }
            return text.Equals(reverse, StringComparison.OrdinalIgnoreCase);
        }

        static void DisplayResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("The string is a Palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not a Palindrome.");
            }
        }
    }
}