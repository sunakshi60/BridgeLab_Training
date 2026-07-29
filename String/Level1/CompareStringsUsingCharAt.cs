using System;

namespace Level1
{
    internal static class CompareStringsUsingCharAt
    {
        public static void Run()
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();
            bool result = CompareStrings(str1, str2);
            Console.WriteLine("Using charAt logic: " + result);
            Console.WriteLine("Using Equals(): " + str1.Equals(str2));
        }

        private static bool CompareStrings(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                    return false;
            }

            return true;
        }
    }
}