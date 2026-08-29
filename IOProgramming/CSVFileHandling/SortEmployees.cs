using System;
using System.IO;
using System.Linq;

public class SortEmployees
{
    public static void Run()
    {
        string filepath = "Employees.csv";
        string[] lines = File.ReadAllLines(filepath);
        var employees = lines
            .Skip(1)
            .Select(line =>
            {
                string[] data = line.Split(',');
                return new
                {
                    ID = int.Parse(data[0]),
                    Name = data[1],
                    Department = data[2],
                    Salary = double.Parse(data[3])
                };
            })
            .OrderByDescending(employee => employee.Salary)
            .Take(5);

        Console.WriteLine("Top 5 Highest-Paid Employees");
        Console.WriteLine("--------------------------------");
        foreach (var employee in employees)
        {
            Console.WriteLine($"ID         : {employee.ID}");
            Console.WriteLine($"Name       : {employee.Name}");
            Console.WriteLine($"Department : {employee.Department}");
            Console.WriteLine($"Salary     : {employee.Salary:F2}");
            Console.WriteLine("--------------------------------");
        }
    }
}