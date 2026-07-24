using System;

namespace Level2PracticeQues
{
    internal static class AthleteRoundsCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Side 1: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Enter Side 2: ");
            double side2 = double.Parse(Console.ReadLine());

            Console.Write("Enter Side 3: ");
            double side3 = double.Parse(Console.ReadLine());

            double perimeter = side1 + side2 + side3;
            double rounds = 5000 / perimeter;

            Console.WriteLine($"The total number of rounds the athlete will run is {rounds:F2} to complete 5 km");
        }
    }
}