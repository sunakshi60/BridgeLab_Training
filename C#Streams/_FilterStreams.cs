using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace C_Streams
{
    public class FilterStreams
    {
        public static void Run()
        {
            string sourceFile = "input.txt";
            string destinationFile = "lowercase.txt";

            try
            {
                using (FileStream inputFileStream = new FileStream(
                    sourceFile,
                    FileMode.Open,
                    FileAccess.Read))
                {
                    using (BufferedStream bufferedInput = new BufferedStream(inputFileStream))
                    {
                        using (StreamReader reader = new StreamReader(
                           bufferedInput,
                           Encoding.UTF8))
                        {
                            using (FileStream outputFileStream = new FileStream(
                                    destinationFile,
                                    FileMode.Create,
                                    FileAccess.Write))
                            {
                                using (BufferedStream bufferedOutput = new BufferedStream(outputFileStream))
                                {
                                    using (StreamWriter writer = new StreamWriter(
                                            bufferedOutput,
                                            Encoding.UTF8))
                                    {
                                        string line;
                                        while ((line = reader.ReadLine()) != null)
                                        {
                                            writer.WriteLine(
                                                line.ToLower());
                                        }
                                    }
                                }
                            }
                        }
                    }

                    Console.WriteLine("File converted to lowercase successfully.");
                }
                Console.WriteLine("File converted to lowercase successfully.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Source file does not exist.");
            }
            catch (DecoderFallbackException)
            {
                Console.WriteLine(
                    "Error while decoding the file.");
            }
            catch (EncoderFallbackException)
            {
                Console.WriteLine(
                    "Error while encoding the file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine(
                    "File handling error: " + ex.Message);
            }
        }
    }
}
