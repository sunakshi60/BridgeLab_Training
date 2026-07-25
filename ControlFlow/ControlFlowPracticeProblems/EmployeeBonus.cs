using System;

namespace ControlFlowPracticeProblems
{
    internal static class EmployeeBonus
    {
        public static void Run()
        {
            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Years of Service: ");
            int years = int.Parse(Console.ReadLine());

            if (years > 5)
            {
                double bonus = salary * 0.05;

                Console.WriteLine($"Bonus Amount = {bonus}");
            }
            else
            {
                Console.WriteLine("No bonus is applicable.");
            }
        }
    }
}