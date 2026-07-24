using System;

namespace PracticeQues
{
    internal static class PenDistribution
    {
        public static void Run()
        {
            Console.Write("Enter Total Pens: ");
            int totalPens = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Students: ");
            int totalStudents = int.Parse(Console.ReadLine());

            int pensPerStudent = totalPens / totalStudents;
            int remainingPens = totalPens % totalStudents;

            Console.WriteLine($"\nThe Pen Per Student is {pensPerStudent} and the remaining pen not distributed is {remainingPens}.");
        }
    }
}