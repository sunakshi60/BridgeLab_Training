using System;

namespace AccessModifiersQues
{
    class Employee
    {
        public int employeeID;
        protected string department;
        private double salary;
        public Employee(int employeeID, string department, double salary)
        {
            this.employeeID = employeeID;
            this.department = department;
            this.salary = salary;
        }
        public void SetSalary(double salary)
        {
            this.salary = salary;
        }
        public double GetSalary()
        {
            return salary;
        }
    }

    class Manager : Employee
    {
        public Manager(int employeeID, string department, double salary)
            : base(employeeID, department, salary)
        {
        }
        public void Display()
        {
            Console.WriteLine("Employee ID : " + employeeID);
            Console.WriteLine("Department  : " + department);
            Console.WriteLine("Salary      : " + GetSalary());
        }
    }
}