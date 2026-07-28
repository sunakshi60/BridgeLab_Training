using System;

namespace PracticeQues
{
    internal static class PalindromeString
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            if (IsPalindrome(text))
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a palindorme");
        }
        private static bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                if (str[left] != str[right])
                    return false;

                left++;
                right--;
            }
            return true;
        }
    }
}