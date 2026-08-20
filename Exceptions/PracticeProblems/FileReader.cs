using System;
using System.IO;

namespace PracticeProblems
{
    public class FileReader
    {
        public void ReadFirstLine()
        {
            try
            {
                using (StreamReader reader = new StreamReader("info.txt"))
                {
                    string firstLine = reader.ReadLine();
                    Console.WriteLine(firstLine);
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
        }
    }
}