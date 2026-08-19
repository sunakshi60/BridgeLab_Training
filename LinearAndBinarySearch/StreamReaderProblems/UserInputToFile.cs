using System;
using System.IO;

namespace StreamReaderProblems
{
    public class UserInputToFile
    {
        public static void WriteUserInput()
        {
            string filePath = "userInput.txt";

            Console.Write("Enter text: ");
            string input = Console.ReadLine() ?? "";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(input);
            }

            Console.WriteLine("Input written to file successfully.");
        }
    }
}