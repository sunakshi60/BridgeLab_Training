using System;

namespace ControlFlowPracticeProblems
{
    internal static class StudentGradeCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Physics Marks: ");
            double physics = double.Parse(Console.ReadLine());

            Console.Write("Enter Chemistry Marks: ");
            double chemistry = double.Parse(Console.ReadLine());

            Console.Write("Enter Maths Marks: ");
            double maths = double.Parse(Console.ReadLine());

            double average = (physics + chemistry + maths) / 3;

            Console.WriteLine($"\nAverage Marks = {average:F2}");

            if (average >= 90)
                Console.WriteLine("Grade : A+\nRemarks : Excellent");
            else if (average >= 80)
                Console.WriteLine("Grade : A\nRemarks : Very Good");
            else if (average >= 70)
                Console.WriteLine("Grade : B\nRemarks : Good");
            else if (average >= 60)
                Console.WriteLine("Grade : C\nRemarks : Average");
            else if (average >= 50)
                Console.WriteLine("Grade : D\nRemarks : Pass");
            else
                Console.WriteLine("Grade : F\nRemarks : Fail");
        }
    }
}