using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace C_Streams
{
    public class BufferedStreams
    {
        const int BufferSize = 4096;
        public static void Run()
        {     
            string sourceFile = @"D:\\C#\\BridgeLabTraining\\C#Collections-Streams\\C#Streams\largefile.txt";
            string normalCopy = "normal_copy.txt";
            string bufferedCopy = "buffered_copy.txt";

            try
            {
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Source file does not exist.");
                    return;
                }

                Stopwatch stopwatch = Stopwatch.StartNew();

                CopyUsingFileStream(sourceFile, normalCopy);

                stopwatch.Stop();

                long normalTime = stopwatch.ElapsedMilliseconds;

                Console.WriteLine("Normal FileStream Time: " + normalTime + " ms");

                stopwatch.Restart();

                CopyUsingBufferedStream(sourceFile, bufferedCopy);

                stopwatch.Stop();

                long bufferedTime = stopwatch.ElapsedMilliseconds;

                Console.WriteLine("BufferedStream Time: " + bufferedTime + " ms");

                Console.WriteLine("\nPerformance Comparison:");

                if (bufferedTime < normalTime)
                {
                    Console.WriteLine("BufferedStream is faster by " + (normalTime - bufferedTime) + " ms.");
                }
                else if (normalTime < bufferedTime)
                {
                    Console.WriteLine(
                        "Normal FileStream is faster by " + (bufferedTime - normalTime) + " ms.");
                }
                else
                {
                    Console.WriteLine("Both took the same time.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File handling error: " + ex.Message);
            }

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
        static void CopyUsingFileStream(string sourceFile, string destinationFile)
        {
            using (FileStream sourceStream = new FileStream(
                sourceFile,
                FileMode.Open,
                FileAccess.Read))
            {
                using (FileStream destinationStream = new FileStream(
                    destinationFile,
                    FileMode.Create,
                    FileAccess.Write))
                {
                    byte[] buffer = new byte[BufferSize];

                    int bytesRead;

                    while ((bytesRead = sourceStream.Read(
                        buffer, 0, buffer.Length)) > 0)
                    {
                        destinationStream.Write(
                            buffer, 0, bytesRead);
                    }
                }
            }
        }

        static void CopyUsingBufferedStream(string sourceFile, string destinationFile)
        {
            using (FileStream sourceFileStream = new FileStream(
                sourceFile,
                FileMode.Open,
                FileAccess.Read))
            {
                using (FileStream destinationFileStream = new FileStream(
                    destinationFile,
                    FileMode.Create,
                    FileAccess.Write))
                {
                    using (BufferedStream bufferedInput =
                        new BufferedStream(
                            sourceFileStream,
                            BufferSize))
                    {
                        using (BufferedStream bufferedOutput =
                            new BufferedStream(
                                destinationFileStream,
                                BufferSize))
                        {
                            byte[] buffer = new byte[BufferSize];

                            int bytesRead;

                            while ((bytesRead = bufferedInput.Read(
                                buffer, 0, buffer.Length)) > 0)
                            {
                                bufferedOutput.Write(
                                    buffer, 0, bytesRead);
                            }
                        }
                    }
                }
            }
        }
    }
}

