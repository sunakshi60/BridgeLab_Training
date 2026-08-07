using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Testing
{
    public class FileProcessor
    {
        public void WriteToFile(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }

        public string ReadFromFile(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new IOException("File does not exist.");
            }
            return File.ReadAllText(filename);
        }
    }
}
