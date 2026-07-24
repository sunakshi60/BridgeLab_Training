using System;

namespace Level2PracticeQues
{
    internal static class SimpleInterestCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Principal: ");
            double principal = double.Parse(Console.ReadLine());

            Console.Write("Enter Rate: ");
            double rate = double.Parse(Console.ReadLine());

            Console.Write("Enter Time: ");
            double time = double.Parse(Console.ReadLine());

            double interest = (principal * rate * time) / 100;

            Console.WriteLine($"The Simple Interest is {interest:F2} for Principal {principal}, Rate of Interest {rate} and Time {time}");
        }
    }
}