using System;
using System.IO;

public class SearchEmployee
{
    public static void Run()
    {
        string filepath = "Employees.csv";
        Console.Write("Enter employee name: ");
        string searchName = Console.ReadLine();
        string[] lines = File.ReadAllLines(filepath);
        bool found = false;
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            string name = data[1];
            if (name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                string department = data[2];
                double salary = double.Parse(data[3]);
                Console.WriteLine("\nEmployee Found!");
                Console.WriteLine($"Department : {department}");
                Console.WriteLine($"Salary     : {salary}");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Employee not found.");
        }
    }
}