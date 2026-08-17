using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace C_Streams
{
    public class UserInputFile
    {
        public static void Run()
        {
            try
            {
                using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                {
                    Console.Write("Enter your name: ");
                    string name = reader.ReadLine();

                    Console.Write("Enter your age: ");
                    int age = Convert.ToInt32(reader.ReadLine());

                    Console.Write("Enter your favorite programming language: ");
                    string language = reader.ReadLine();

                    using (StreamWriter writer = new StreamWriter("userdetails.txt"))
                    {
                        writer.WriteLine("Name: " + name);
                        writer.WriteLine("Age: " + age);
                        writer.WriteLine("Favorite Programming Language: " + language);
                    }
                }

                Console.WriteLine("User information saved successfully.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid age.");
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
