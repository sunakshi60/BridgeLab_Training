using System;

namespace Level1
{
    class Employee
    {
        // Fields (Attributes)
        private string name;
        private int id;
        private double salary;

        // Constructor
        public Employee(string name,int id,double salary)
        {

            this.name = name;
            this.id = id;
            this.salary = salary;
        }

        // Method
        public void DisplayDetails()
        {
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee ID   : " + id);
            Console.WriteLine("Salary        : " + salary);
        }
    }
}