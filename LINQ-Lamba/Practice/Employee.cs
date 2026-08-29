using System;

public class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }

    public Employee(string name, string department)
    {
        Name = name;
        Department = department;
    }
}