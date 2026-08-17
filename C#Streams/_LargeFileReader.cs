using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace C_Streams
{
    internal class LargeFileReader
    {
        public static void Run()
        {
            string fileName = "largefile.txt";

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains("error",
                            StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine(line);
                        }
                    }
                }

                Console.WriteLine("\nFile reading completed.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File does not exist.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("File handling error: " + ex.Message);
            }
        }
    }
}
