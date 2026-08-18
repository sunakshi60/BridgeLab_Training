using System;
using System.Collections.Generic;

namespace Questions
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public Employee(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Department: {Department}";
        }
    }


    public class EmployeeRecordSystem
    {
        private Dictionary<int, Employee> employees;

        public EmployeeRecordSystem()
        {
            employees = new Dictionary<int, Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            if (employees.ContainsKey(employee.Id))
            {
                Console.WriteLine("Employee ID already exists.");
                return;
            }

            employees.Add(employee.Id, employee);
            Console.WriteLine("Employee added successfully.");
        }

        public Employee SearchEmployee(int id)
        {
            if (employees.TryGetValue(id, out Employee employee))
            {
                return employee;
            }

            return null;
        }

        public bool UpdateDepartment(int id, string newDepartment)
        {
            if (employees.TryGetValue(id, out Employee employee))
            {
                employee.Department = newDepartment;
                return true;
            }

            return false;
        }

        public bool RemoveEmployee(int id)
        {
            return employees.Remove(id);
        }

        public void DisplayAllEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employee records found.");
                return;
            }

            foreach (KeyValuePair<int, Employee> entry in employees)
            {
                Console.WriteLine(entry.Value);
            }
        }
    }
}