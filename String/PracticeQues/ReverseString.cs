using System;
using System.Reflection;

namespace PracticeQues
{
    internal static class ReverseString
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            string reversed = Reverse(text);
            Console.WriteLine("Reverse String: " + reversed);
        }
        public static string Reverse(string str)
        {
            string result = "";
            for(int i = str.Length-1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }
    }
}