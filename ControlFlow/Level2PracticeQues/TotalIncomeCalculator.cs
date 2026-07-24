using System;

namespace Level2PracticeQues
{
    internal static class TotalIncomeCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Enter Bonus: ");
            double bonus = double.Parse(Console.ReadLine());

            double income = salary + bonus;

            Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence Total Income is INR {income}");
        }
    }
}