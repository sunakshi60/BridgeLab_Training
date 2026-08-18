using System;
using System.Text;

namespace StringBuilderProblems
{
    public class StringConcatenation
    {
        public static void Run()
        {
            string[] words =
            {
                "Hello ",
                "This ",
                "is ",
                "a ",
                "StringBuilder ",
                "example."
            };

            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                result.Append(word);
            }

            Console.WriteLine(result.ToString());
        }
    }
}