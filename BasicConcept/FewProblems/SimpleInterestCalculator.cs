using System;

namespace FewProblems
{
    internal static class SimpleInterestCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Principal Amount: ");
            double principal = double.Parse(Console.ReadLine());

            Console.Write("Enter Rate of Interest: ");
            double rate = double.Parse(Console.ReadLine());

            Console.Write("Enter Time: ");
            double time = double.Parse(Console.ReadLine());

            double simpleInterest = (principal * rate * time) / 100;

            Console.WriteLine($"Simple Interest is {simpleInterest:F2}");
        }
    }
}