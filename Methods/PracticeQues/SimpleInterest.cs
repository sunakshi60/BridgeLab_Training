using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeQues
{
    internal class SimpleInterest
    {
        public static void Run()
        {
            Console.Write("Enter Principal: ");
            double principal = double.Parse(Console.ReadLine());
            Console.Write("Enter Rate of Interest: ");
            double rate = double.Parse(Console.ReadLine());
            Console.Write("Enter Time (in years): ");
            double time = double.Parse(Console.ReadLine());
            double simpleInterest = CalculateSimpleInterest(principal, rate, time);
            Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate}% and Time {time} years.");
        }

        public static double CalculateSimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }
    }
}
