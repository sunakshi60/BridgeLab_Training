using System;
using System.IO;

namespace StreamReaderProblems
{
    public class ReadFileLineByLine
    {
        public static void ReadFile()
        {
            string filePath = "sample.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }
            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}