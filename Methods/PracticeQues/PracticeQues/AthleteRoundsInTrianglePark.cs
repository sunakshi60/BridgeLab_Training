using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace PracticeQues
{
    internal class AthleteRoundsInTrianglePark
    {
        public static void Run()
        {
            Console.WriteLine("Enter the length of first side of triangle in (meters): ");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of second side of triangle in (meters): ");
            double side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the length of third side of triangle in (meters): ");
            double side3 = double.Parse(Console.ReadLine());

            double rounds = CalculateRounds( side1,  side2,  side3);

            Console.WriteLine($"The athlete needs to complete {rounds:F2} rounds to run 5km.");  

        }

        public static double CalculateRounds(double side1,double side2,double side3)
        {
            double perimeter = side1 + side2 + side3;
            double totalDistance = 5000;

            return totalDistance / perimeter;
        }
        
    }
}
