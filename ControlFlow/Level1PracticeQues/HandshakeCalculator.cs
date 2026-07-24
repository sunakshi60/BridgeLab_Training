using System;

namespace PracticeQues
{
    internal static class HandshakeCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Number of Students: ");
            int numberOfStudents = int.Parse(Console.ReadLine());

            int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;

            Console.WriteLine($"The maximum number of possible handshakes is {handshakes}");
        }
    }
}