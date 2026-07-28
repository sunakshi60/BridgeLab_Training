using System;

namespace PracticeQues
{
    internal static class CalendarDisplay
    {
        public static void Run()
        {
            Console.Write("Enter month (1-12): ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            DisplayCalendar(month, year);
        }

        public static void DisplayCalendar(int month, int year)
        {
            string[] months =
            {
                "January", "February", "March", "April",
                "May", "June", "July", "August",
                "September", "October", "November", "December"
            };
            int[] days =
            {
                31,28,31,30,31,30,
                31,31,30,31,30,31
            };
            if (IsLeapYear(year))
            {
                days[1] = 29;
            }
            Console.WriteLine($"\n\t{months[month - 1]} {year}");
            Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
            int firstDay = GetFirstDay(month, year);
            for (int i = 0; i < firstDay; i++)
            {
                Console.Write("    ");
            }
            for (int date = 1; date <= days[month - 1]; date++)
            {
                Console.Write($"{date,3} ");

                if ((firstDay + date) % 7 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) ||
                   (year % 400 == 0);
        }

        public static int GetFirstDay(int month, int year)
        {
            int d = 1;
            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int day = (d + x + (31 * m0) / 12) % 7;
            return day;
        }
    }
}