using System;
using System.Collections.Generic;
using System.Text;

namespace C_Streams
{
    public class DataStreams
    {
        public static void Run()
        {
            string fileName = "student.dat";

            try
            {
                using (FileStream fileStream = new FileStream(
                    fileName,
                    FileMode.Create,
                    FileAccess.Write))
                {
                    using (BinaryWriter writer = new BinaryWriter(fileStream))
                    {
                        writer.Write(101);
                        writer.Write("Sunakshi");
                        writer.Write(8.27);
                    }
                }
                Console.WriteLine("Student details saved successfully.");

                using (FileStream fileStream = new FileStream(
                    fileName,
                    FileMode.Open,
                    FileAccess.Read))
                {
                    using (BinaryReader reader = new BinaryReader(fileStream))
                    {
                        int rollNumber = reader.ReadInt32();
                        string name = reader.ReadString();
                        double gpa = reader.ReadDouble();

                        Console.WriteLine("\nStudent Details:");
                        Console.WriteLine("Roll Number: " + rollNumber);
                        Console.WriteLine("Name: " + name);

                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File handling error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
