using System;
using System.IO;
using System.Text.RegularExpressions;

public class ValidateCsvData
{
    public static void Run()
    {
        string filepath = "Employees.csv";
        string[] lines = File.ReadAllLines(filepath);
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string phonePattern = @"^\d{10}$";
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            string email = data[2];
            string phone = data[3];
            bool validEmail = Regex.IsMatch(email, emailPattern);
            bool validPhone = Regex.IsMatch(phone, phonePattern);
            if (!validEmail || !validPhone)
            {
                Console.WriteLine($"Invalid Row {i + 1}: {lines[i]}");

                if (!validEmail)
                {
                    Console.WriteLine("Error: Invalid email format.");
                }

                if (!validPhone)
                {
                    Console.WriteLine("Error: Phone number must contain exactly 10 digits.");
                }
                Console.WriteLine();
            }
        }
    }
}