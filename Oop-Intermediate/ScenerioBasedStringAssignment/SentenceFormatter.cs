using System;
using System.IO;
using System.Text;

namespace ScenerioBasedStringAssignment
{
    internal class SentenceFormatter
    {
        public static void Run()
        {
            Console.Write("Enter paragraph: ");
            string input = Console.ReadLine();

            Console.WriteLine("\nFormatted Paragraph: ");
            Console.WriteLine(FormatParagraph(input));
        }

        static string FormatParagraph(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return "Input is empty.";

            text = text.Trim();

            StringBuilder formatted = new StringBuilder();

            bool capitalizeNext = true;
            bool previousSpace = false;

            foreach(char ch in text)
            {
                if (char.IsWhiteSpace(ch))
                {
                    if (!previousSpace)
                    {
                        formatted.Append(' ');
                        previousSpace = true;
                    }
                }
                else
                {
                    if(capitalizeNext && char.IsLetter(ch))
                    {
                        formatted.Append(char.ToUpper(ch));
                        capitalizeNext = false;
                    }
                    else
                    {
                        formatted.Append(ch);
                    }
                    previousSpace = false;
                    if (ch == '.' || ch == '?' || ch == '!')
                    {
                        capitalizeNext = true;
                    }
                }
            }
            string result = formatted.ToString();

            result = result.Replace(".", ". ");
            result = result.Replace("?", "? ");
            result = result.Replace("!", "! ");

            while (result.Contains("  "))
            {
                result = result.Replace("  ", " ");
            }

            return result.Trim();
        }
    }
}