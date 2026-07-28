using System;

namespace PracticeQues
{
    internal static class EmployeeBonusCalculator
    {
        public static void Run()
        {
            double[,] employees = GenerateEmployeeData(10);
            double[,] updatedEmployees = CalculateBonusAndNewSalary(employees);
            DisplayEmployeeDetails(updatedEmployees);
        }

        public static double[,] GenerateEmployeeData(int size)
        {
            Random random = new Random();
            double[,] employees = new double[size, 4];
            for (int i = 0; i < size; i++)
            {
                employees[i, 0] = random.Next(10000, 100000); // Old Salary
                employees[i, 1] = random.Next(1, 11);         // Years of Service
            }
            return employees;
        }

        public static double[,] CalculateBonusAndNewSalary(double[,] employees)
        {
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                double salary = employees[i, 0];
                double years = employees[i, 1];
                double bonus;
                if (years > 5)
                {
                    bonus = salary * 0.05;
                }
                else
                {
                    bonus = salary * 0.02;
                }
                employees[i, 2] = bonus;
                employees[i, 3] = salary + bonus;
            }
            return employees;
        }

        public static void DisplayEmployeeDetails(double[,] employees)
        {
            double totalOldSalary = 0;
            double totalBonus = 0;
            double totalNewSalary = 0;
            Console.WriteLine("Emp\tOld Salary\tYears\tBonus\tNew Salary");
            for (int i = 0; i < employees.GetLength(0); i++)
            {
                Console.WriteLine($"{i + 1}\t{employees[i, 0]:F2}\t\t{employees[i, 1]}\t{employees[i, 2]:F2}\t{employees[i, 3]:F2}");
                totalOldSalary += employees[i, 0];
                totalBonus += employees[i, 2];
                totalNewSalary += employees[i, 3];
            }
            Console.WriteLine("\n-------");
            Console.WriteLine($"Total Old Salary : {totalOldSalary:F2}");
            Console.WriteLine($"Total Bonus      : {totalBonus:F2}");
            Console.WriteLine($"Total New Salary : {totalNewSalary:F2}");
        }
    }
}