using System;

namespace Level2PracticeQues
{
    internal static class ChocolateDistributionCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Number of Chocolates: ");
            int chocolates = int.Parse(Console.ReadLine());

            Console.Write("Enter Number of Children: ");
            int children = int.Parse(Console.ReadLine());

            int eachChild = chocolates / children;
            int remaining = chocolates % children;

            Console.WriteLine($"The number of chocolates each child gets is {eachChild} and the number of remaining chocolates is {remaining}");
        }
    }
}