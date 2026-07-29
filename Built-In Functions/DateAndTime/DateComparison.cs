using System;

namespace DateAndTime
{
    class DateComparison
    {
        public static void Run()
        {
            Console.Write("Enter a First Date (dd/MM/yyyy): ");
            DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Enter a Second Date (dd/MM/yyyy): ");
            DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            int result = DateTime.Compare(date1, date2);
            if (result < 0)
            {
                Console.WriteLine("First date is before the second date.");
            }
            else if (result > 0)
            {
                Console.WriteLine("First date is after the second date.");
            } else
            {
                Console.WriteLine("Both dates are the same");
            }
        }
    }
}