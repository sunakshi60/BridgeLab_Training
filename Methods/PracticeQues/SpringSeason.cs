using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal class SpringSeason
    {
        public static void Run()
        {
            Console.Write("Enter month (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Enter day: ");
            int day = int.Parse(Console.ReadLine());

            bool isSpring = IsSpringSeason(month, day);

            if (isSpring)
            {
                Console.WriteLine("Its a Spring Season");
            }
            else
            {
                Console.WriteLine("Not a Spring Season");
            }
        }
        public static bool IsSpringSeason(int month, int day)
        {
            if ((month == 3 && day >= 20) ||
                (month == 4) ||
                (month == 5) ||
                (month == 6 && day <= 20))
            {
                return true;
            }

            return false;
        }
    }
}
