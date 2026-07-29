using System;

namespace DateAndTime
{
    class DateArithmetic
    {
        public static void Run()
        {
            Console.Write("Enter a date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);

            date = date.AddDays(7);
            date = date.AddMonths(1);
            date = date.AddYears(2);
            Console.WriteLine("After adding 7 days, 1 month, and 2 years: " +date.ToString("dd/MM/yyyy"));
            date = date.AddDays(-21);

            Console.WriteLine("After subtracting 3 weeks: " +date.ToString("dd/MM/yyyy"));
        }
    }
}