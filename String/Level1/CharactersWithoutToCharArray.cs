using System;

namespace Level1
{
    internal static class CharactersWithoutToCharArray
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            Console.WriteLine("Using Loop:");
            PrintCharacters(text);
            Console.WriteLine("\nUsing ToCharArray():");
            char[] arr = text.ToCharArray();
            foreach (char ch in arr)
            {
                Console.Write(ch + " ");
            }
        }

        private static void PrintCharacters(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i] + " ");
            }
        }
    }
}