using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace C_Streams
{
    public class ByteArrayStreamExample
    {
        public static void Run()
        {
            string sourceImage = "image.jpg";
            string destinationImage = "image_copy.jpg";

            try
            {
                byte[] imageBytes = File.ReadAllBytes(sourceImage);

                Console.WriteLine("Image converted to byte array.");
                Console.WriteLine("Image size: " + imageBytes.Length + " bytes");

                using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                {
                    byte[] outputBytes = memoryStream.ToArray();

                    File.WriteAllBytes(destinationImage, outputBytes);
                }

                Console.WriteLine("Image written to new file successfully.");

                byte[] originalBytes = File.ReadAllBytes(sourceImage);
                byte[] copiedBytes = File.ReadAllBytes(destinationImage);

                bool areIdentical = true;

                if (originalBytes.Length != copiedBytes.Length)
                {
                    areIdentical = false;
                }
                else
                {
                    for (int i = 0; i < originalBytes.Length; i++)
                    {
                        if (originalBytes[i] != copiedBytes[i])
                        {
                            areIdentical = false;
                            break;
                        }
                    }
                }
                if (areIdentical)
                {
                    Console.WriteLine("Verification successful.");
                    Console.WriteLine("Original and copied images are identical.");
                }
                else
                {
                    Console.WriteLine("Verification failed.");
                    Console.WriteLine("Images are different.");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File handling error: " + ex.Message);
            }
        }
    }
}
