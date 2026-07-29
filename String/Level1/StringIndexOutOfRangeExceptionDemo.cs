using System;

namespace Level1
{
    internal static class StringIndexOutOfRangeExceptionDemo
    {
        public static void Run()
        {
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            try
            {
                DisplayCharacter(text);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception Caught:");
                Console.WriteLine(ex.Message);
            }
        }

        private static void DisplayCharacter(string str)
        {
            Console.WriteLine(str[str.Length]);
        }
    }
}