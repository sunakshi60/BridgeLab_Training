using System;

namespace PracticeProblems
{
    internal static class StudentVoteChecker
    {
        public static void Run()
        {
            int[] ages = new int[10];
            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write($"Enter age of student {i + 1}: ");
                ages[i] = int.Parse(Console.ReadLine());
                if (CanStudentVote(ages[i]))
                {
                    Console.WriteLine("Can Vote");
                }
                else
                {
                    Console.WriteLine("Cannot Vote");
                }
            }
        }

        public static bool CanStudentVote(int age)
        {
            if (age < 0)
            {
                return false;
            }
            return age >= 18;
        }
    }
}