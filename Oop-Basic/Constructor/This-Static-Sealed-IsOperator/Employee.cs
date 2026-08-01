using System;

namespace This_Static_Sealed_IsOperator
{
    class Employee
    {
        static string companyName = "EasyRewardz";
        static int totalEmployees = 0;
        public readonly int id;
        string name;
        string designation;

        public Employee(int id, string name, string designation)
        {
            this.id = id;
            this.name = name;
            this.designation = designation;

            totalEmployees++;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("\nEmployee Details");
            Console.WriteLine("Company Name : " + companyName);
            Console.WriteLine("Employee ID  : " + id);
            Console.WriteLine("Name         : " + name);
            Console.WriteLine("Designation  : " + designation);
        }
        public static void DisplayTotalEmployees()
        {
            Console.WriteLine("\nTotal Employees : " + totalEmployees);
        }
    }
}