using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ProblemsStatements
{
    public class LargeFileReadingPerformance
    {
        public static void Run()
        {
            string filePath = "largeFile.txt";

            int fileSizeInMB = 10;

            Console.WriteLine("Creating test file...");

            CreateLargeTextFile(filePath, fileSizeInMB);

            Console.WriteLine($"File created: {fileSizeInMB} MB");

            Console.WriteLine();

            Stopwatch streamReaderWatch = Stopwatch.StartNew();

            long streamReaderCharacters = ReadUsingStreamReader(filePath);

            streamReaderWatch.Stop();

            Stopwatch fileStreamWatch = Stopwatch.StartNew();

            long fileStreamBytes = ReadUsingFileStream(filePath);

            fileStreamWatch.Stop();

            Console.WriteLine("Performance Results");
            Console.WriteLine("----------------------------");

            Console.WriteLine($"StreamReader Time : {streamReaderWatch.ElapsedMilliseconds} ms");

            Console.WriteLine($"FileStream Time   : {fileStreamWatch.ElapsedMilliseconds} ms");

            Console.WriteLine();

            Console.WriteLine($"Characters read using StreamReader: {streamReaderCharacters}");

            Console.WriteLine($"Bytes read using FileStream: {fileStreamBytes}");

            File.Delete(filePath);

            Console.WriteLine();
            Console.WriteLine("Test file deleted.");
        }


        private static void CreateLargeTextFile(string filePath,int sizeInMB)
        {
            long targetSize = (long)sizeInMB * 1024 * 1024;

            string text = "This is a sample line used for testing large file reading performance.\n";

            byte[] data = Encoding.UTF8.GetBytes(text);

            using (FileStream fileStream = new FileStream(
                filePath,
                FileMode.Create,
                FileAccess.Write))
            {
                long written = 0;

                while (written < targetSize)
                {
                    fileStream.Write(data, 0, data.Length);
                    written += data.Length;
                }
            }
        }

        private static long ReadUsingStreamReader(string filePath)
        {
            long characterCount = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                char[] buffer = new char[4096];

                int charactersRead;

                while ((charactersRead =
                    reader.Read(buffer, 0, buffer.Length)) > 0)
                {
                    characterCount += charactersRead;
                }
            }

            return characterCount;
        }

        private static long ReadUsingFileStream(string filePath)
        {
            long byteCount = 0;

            using (FileStream fileStream = new FileStream(
                filePath,
                FileMode.Open,
                FileAccess.Read))
            {
                byte[] buffer = new byte[4096];

                int bytesRead;

                while ((bytesRead =
                    fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    byteCount += bytesRead;
                }
            }

            return byteCount;
        }
    }
}