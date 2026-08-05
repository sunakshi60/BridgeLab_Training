using System;
using System.Xml.Linq;

namespace PracticeProblems
{
    interface IDepartment
    {
        void AssignDepartment(string department);
        void GetDepartmentDetails();
    }
    abstract class Employee
    {
        private int employeeId;
        private string name;
        private double baseSalary;
        public int EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double BaseSalary
        {
            get { return baseSalary; }
            set { baseSalary = value; }
        }
        public Employee(int id,string name,double salary)
        {
            employeeId = id;
            Name = name;
            baseSalary = salary;
        }

        public abstract double CalculateSalary();

        public void DisplayDetails()
        {
            Console.WriteLine($"EmployeeID : {employeeId}");
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"Salary : {CalculateSalary()}");
        }
    }

    class FullTimeEmployee : Employee, IDepartment
    {
        private string department;
        public FullTimeEmployee(int id,string name,double salary) : base(id, name, salary)
        {
        }
        
        public override double CalculateSalary()
        {
            return BaseSalary;
        }

        public void AssignDepartment(string department)
        {
            this.department = department;
        }

        public void GetDepartmentDetails()
        {
            Console.WriteLine($"Department : {department}");
        }
    }

    class PartTimeEmployee : Employee,IDepartment
    {
        private int workHours;
        private double hourlyRate;
        private string department;

        public PartTimeEmployee(int id, string name, double hourlyRate, int workHours) : base(id, name, 0)
        {
            this.hourlyRate = hourlyRate;
            this.workHours = workHours;
        }
        public override double CalculateSalary()
        {
            return workHours * hourlyRate;
        }
        public void AssignDepartment(string department)
        {
            this.department = department;
        }
        public void GetDepartmentDetails()
        {
            Console.WriteLine($"Department  : {department}");
        }
    }
}