using System;
using System.IO;
using System.Collections.Generic;

public class UpdateEmployeeSalary
{
    public static void Run()
    {
        string inputFile = "Employees.csv";
        string outputFile = "UpdatedEmployees.csv";
        string[] lines = File.ReadAllLines(inputFile);
        List<string> updatedRecords = new List<string>();
        updatedRecords.Add(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            string department = data[2];
            double salary = double.Parse(data[3]);
            if (department.Equals("IT", StringComparison.OrdinalIgnoreCase))
            {
                salary = salary * 1.10;
            }
            data[3] = salary.ToString("F2");
            updatedRecords.Add(string.Join(",", data));
        }
        File.WriteAllLines(outputFile, updatedRecords);
        Console.WriteLine("Employee salaries updated successfully.");
        Console.WriteLine($"Updated file: {outputFile}");
    }
}