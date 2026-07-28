using System;

namespace Strings
{
    internal static class LexicographicalStringComparison
    { 
        public static void Run()
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();
            CompareStrings(str1, str2);
        }

        private static void CompareStrings(string str1, string str2)
        {
            int minLength = Math.Min(str1.Length, str2.Length);
            for (int i = 0; i < minLength; i++)
            {
                if (str1[i] < str2[i])
                {
                    Console.WriteLine($"\"{str1}\" comes before \"{str2}\"");
                    return;
                }
                else if (str1[i] > str2[i])
                {
                    Console.WriteLine($"\"{str2}\" comes before \"{str1}\"");
                    return;
                }
            }
            if (str1.Length < str2.Length)
                Console.WriteLine($"\"{str1}\" comes before \"{str2}\"");
            else if (str1.Length > str2.Length)
                Console.WriteLine($"\"{str2}\" comes before \"{str1}\"");
            else
                Console.WriteLine("Both strings are equal.");
        }
    }
}