using System;

namespace DateAndTime
{
    class DateFormatting
    {
        public static void Run()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Current Date in Different Formats");
            // Format 1: dd/MM/yyyy
            Console.WriteLine(currentDate.ToString("dd/MM/yyyy"));
            // Format 2: yyyy-MM-dd
            Console.WriteLine(currentDate.ToString("yyyy-MM-dd"));
            // Format 3: EEE, MMM dd, yyyy
            Console.WriteLine(currentDate.ToString("ddd, MMM dd, yyyy"));
        }
    }
}