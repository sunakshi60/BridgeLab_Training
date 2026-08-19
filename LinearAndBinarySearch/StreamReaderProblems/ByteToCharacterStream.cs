using System;
using System.IO;
using System.Text;

namespace StreamReaderProblems
{
    public class ByteToCharacterStream
    {
        public static void ConvertToCharacters()
        {
            string filePath = "sample.txt";

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File not found.");
                return;
            }

            using (FileStream fileStream = new FileStream(
                filePath,
                FileMode.Open,
                FileAccess.Read))
            {
                using (StreamReader reader = new StreamReader(
                    fileStream, Encoding.UTF8))
                {
                    int character;

                    while ((character = reader.Read()) != -1)
                    {
                        Console.Write((char)character);
                    }
                }
            }
        }
    }
}