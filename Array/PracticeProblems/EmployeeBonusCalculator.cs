using System;

namespace PracticeProblems
{
    internal static class EmployeeBonusCalculator
    {
        public static void Run()
        {
            const int employeeCount = 10;

            double[] salaries = new double[employeeCount];
            double[] yearsOfService = new double[employeeCount];
            double[] bonusAmounts = new double[employeeCount];
            double[] updatedSalaries = new double[employeeCount];

            double totalOldSalary = 0;
            double totalBonus = 0;
            double totalNewSalary = 0;

            for (int i = 0; i < employeeCount; i++)
            {
                Console.WriteLine($"\nEmployee {i + 1}");

                Console.Write("Enter Salary: ");
                salaries[i] = double.Parse(Console.ReadLine());

                Console.Write("Enter Years of Service: ");
                yearsOfService[i] = double.Parse(Console.ReadLine());

                if (salaries[i] <= 0 || yearsOfService[i] < 0)
                {
                    Console.WriteLine("Invalid input. Please enter valid details.");
                    i--;
                }
            }

            for (int i = 0; i < employeeCount; i++)
            {
                double bonusPercentage = yearsOfService[i] > 5 ? 0.05 : 0.02;

                bonusAmounts[i] = salaries[i] * bonusPercentage;
                updatedSalaries[i] = salaries[i] + bonusAmounts[i];

                totalOldSalary += salaries[i];
                totalBonus += bonusAmounts[i];
                totalNewSalary += updatedSalaries[i];
            }

            Console.WriteLine("\nEmployee Bonus Details");
            Console.WriteLine("Employee\tSalary\t\tYears\tBonus\t\tNew Salary");

            for (int i = 0; i < employeeCount; i++)
            {
                Console.WriteLine($"{i + 1}\t\t{salaries[i]}\t\t{yearsOfService[i]}\t{bonusAmounts[i]}\t\t{updatedSalaries[i]}");
            }

            Console.WriteLine($"Total Old Salary : {totalOldSalary}");
            Console.WriteLine($"Total Bonus      : {totalBonus}");
            Console.WriteLine($"Total New Salary : {totalNewSalary}");
        }
    }
}