using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, string designation, decimal salary)
        {
            ID = id;
            Name = name;
            Designation = designation;
            Salary = salary;
        }
    }

    //Target Interface
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }


    //Adaptee
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine(
                    "Rs." + employee.Salary +
                    " Salary Credited to " +
                    employee.Name +
                    " Account"
                );
            }
        }
    }

    //Adapter
    public class EmployeeAdapter : ITarget
    {
        private ThirdPartyBillingSystem thirdPartyBillingSystem = new ThirdPartyBillingSystem();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> listEmployee = new List<Employee>();

            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                string id = employeesArray[i, 0];
                string name = employeesArray[i, 1];
                string designation = employeesArray[i, 2];
                string salary = employeesArray[i, 3];

                listEmployee.Add(
                    new Employee(
                        Convert.ToInt32(id),
                        name,
                        designation,
                        Convert.ToDecimal(salary)
                    )
                );
            }

            Console.WriteLine(
                "Adapter converted String Array to List<Employee>"
            );

            thirdPartyBillingSystem.ProcessSalary(listEmployee);
        }
    }
}