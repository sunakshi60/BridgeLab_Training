using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal class MaximumHandshakes
    {
        public static void Run()
        {
            Console.Write("Enter the number of students: ");
            int students = int.Parse(Console.ReadLine());
            int handshakes = CalculateHandshakes(students);
            Console.WriteLine($"Maximum possible handshakes = {handshakes}");
        }

        public static int CalculateHandshakes(int numberOfStudents)
        {
            return (numberOfStudents * (numberOfStudents - 1)) / 2;
        }


    }
}

