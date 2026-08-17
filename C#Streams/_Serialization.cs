using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace C_Streams
{

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }
    }

    class Serialization
    {
        public static void Run()
        {
            string fileName = "employees.json";

            try
            {
                List<Employee> employees = new List<Employee>
            {
                new Employee
                {
                    Id = 101,
                    Name = "Rahul",
                    Department = "IT",
                    Salary = 50000
                },

                new Employee
                {
                    Id = 102,
                    Name = "Priya",
                    Department = "HR",
                    Salary = 45000
                },

                new Employee
                {
                    Id = 103,
                    Name = "Aman",
                    Department = "Finance",
                    Salary = 60000
                }
            };

                string json = JsonSerializer.Serialize(
                    employees,
                    new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

                File.WriteAllText(fileName, json);

                Console.WriteLine("Employees serialized successfully.");

                string savedJson = File.ReadAllText(fileName);

                List<Employee> retrievedEmployees = JsonSerializer.Deserialize<List<Employee>>(savedJson);

                Console.WriteLine("\nRetrieved Employees:");

                foreach (Employee employee in retrievedEmployees)
                {
                    Console.WriteLine(
                        $"ID: {employee.Id}, " +
                        $"Name: {employee.Name}, " +
                        $"Department: {employee.Department}, " +
                        $"Salary: {employee.Salary}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File handling error: " + ex.Message);
            }
            catch (JsonException ex)
            {
                Console.WriteLine("Serialization error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}