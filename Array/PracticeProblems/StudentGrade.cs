using System;

namespace PracticeProblems
{
    internal static class StudentGrade
    {
        public static void Run()
        {
            Console.Write("Enter number of students: ");
            int students = int.Parse(Console.ReadLine());

            int[] physics = new int[students];
            int[] chemistry = new int[students];
            int[] maths = new int[students];

            double[] percentage = new double[students];
            string[] grade = new string[students];

            for (int i = 0; i < students; i++)
            {
                Console.WriteLine($"\nStudent {i + 1}");

                Console.Write("Physics: ");
                physics[i] = int.Parse(Console.ReadLine());

                Console.Write("Chemistry: ");
                chemistry[i] = int.Parse(Console.ReadLine());

                Console.Write("Maths: ");
                maths[i] = int.Parse(Console.ReadLine());

                if (physics[i] < 0 || chemistry[i] < 0 || maths[i] < 0)
                {
                    Console.WriteLine("Marks cannot be negative. Please enter all marks again.");
                    i--;          
                    continue;
                }

                percentage[i] = (physics[i] + chemistry[i] + maths[i]) / 3.0;

                if (percentage[i] >= 90)
                    grade[i] = "A";
                else if (percentage[i] >= 75)
                    grade[i] = "B";
                else if (percentage[i] >= 50)
                    grade[i] = "C";
                else if (percentage[i] >= 35)
                    grade[i] = "D";
                else
                    grade[i] = "F";
            }

            Console.WriteLine("\nPhy\tChem\tMath\tPercentage\tGrade");

            for (int i = 0; i < students; i++)
            {
                Console.WriteLine($"{physics[i]}\t{chemistry[i]}\t{maths[i]}\t{percentage[i]:F2}\t\t{grade[i]}");
            }
        }
    }
}