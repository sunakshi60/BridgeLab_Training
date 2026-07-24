using System;

namespace PracticeQues
{
    internal static class HarryAge
    {
        public static void Run()
        {
            Console.Write("Enter Birth Year: ");
            int birthYear = int.Parse(Console.ReadLine());
            Console.Write("Enter Current Year: ");
            int currentYear = int.Parse(Console.ReadLine());

            int age = currentYear - birthYear;

            Console.WriteLine($"Harry's age in {currentYear} is {age}");
        }
    }
}