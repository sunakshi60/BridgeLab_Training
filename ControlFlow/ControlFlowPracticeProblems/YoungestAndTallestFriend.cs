using System;

namespace ControlFlowPracticeProblems
{
    internal static class YoungestAndTallestFriend
    {
        public static void Run()
        {
            Console.Write("Enter Amar's Age: ");
            int amarAge = int.Parse(Console.ReadLine());

            Console.Write("Enter Akbar's Age: ");
            int akbarAge = int.Parse(Console.ReadLine());

            Console.Write("Enter Anthony's Age: ");
            int anthonyAge = int.Parse(Console.ReadLine());

            Console.Write("Enter Amar's Height: ");
            double amarHeight = double.Parse(Console.ReadLine());

            Console.Write("Enter Akbar's Height: ");
            double akbarHeight = double.Parse(Console.ReadLine());

            Console.Write("Enter Anthony's Height: ");
            double anthonyHeight = double.Parse(Console.ReadLine());

            if (amarAge <= akbarAge && amarAge <= anthonyAge)
                Console.WriteLine("Youngest : Amar");
            else if (akbarAge <= anthonyAge)
                Console.WriteLine("Youngest : Akbar");
            else
                Console.WriteLine("Youngest : Anthony");

            if (amarHeight >= akbarHeight && amarHeight >= anthonyHeight)
                Console.WriteLine("Tallest : Amar");
            else if (akbarHeight >= anthonyHeight)
                Console.WriteLine("Tallest : Akbar");
            else
                Console.WriteLine("Tallest : Anthony");
        }
    }
}