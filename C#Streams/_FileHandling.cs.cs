using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace C_Streams
{
    public class FileHandling
    {
        public static void Run()
        {
            string sourceFile = "source.txt";
            string destinationFile = "destination.txt";

            try
            {
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Source file does not exist.");
                    Console.ReadLine();
                    return;
                }

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
                        int data;
                        while ((data = sourceStream.ReadByte()) != -1)
                        {
                            destinationStream.WriteByte((byte)data);
                        }
                    }
                }
                Console.WriteLine("File copied successfully");
            }
            catch (IOException ex)
            {
                Console.WriteLine("File handling error:" + ex.Message);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
