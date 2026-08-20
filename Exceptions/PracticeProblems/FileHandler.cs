using System;
using System.IO;

namespace PracticeProblems
{
    public class FileHandler
    {
        public void ReadFile()
        {
            try
            {
                string content = File.ReadAllText("data.txt");
                Console.WriteLine("File Content:");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File Not Found");
            }
            catch (IOException)
            {
                Console.WriteLine("Error while accessing the file");
            }
        }
    }
}