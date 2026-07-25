using System;

namespace PracticeProblems
{
    internal class StudentVotingEligibility
    {
        public static void Run()
        {
            int[] ages = new int[10];
            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write($"Enter age of student{i + 1}: ");
                ages[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("\nResult: ");
            for(int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < 0)
                {
                    Console.WriteLine($"An invalid age:{ages[i]}.");
                } 
                else if (ages[i] >= 18)
                {
                    Console.WriteLine($"The student with the age {ages[i]} can vote.");
                }
                else
                {
                    Console.WriteLine($"The student with the age {ages[i]} cannot vote.");
                }
            }
        }
    }
}