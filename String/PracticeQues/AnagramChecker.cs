using System;

namespace PracticeQues
{
    internal static class AnagramChecker
    {
        public static void Run()
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine().ToLower();
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine().ToLower();
            if (IsAnagram(str1, str2))
                Console.WriteLine("Strings are Anagrams.");
            else
                Console.WriteLine("Strings are Not Anagrams.");
        }

        private static bool IsAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }
           return true;
        }
    }
}