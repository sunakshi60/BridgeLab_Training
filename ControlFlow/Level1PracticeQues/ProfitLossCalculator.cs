using System;

namespace PracticeQues
{
    internal static class ProfitLossCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Cost Price: ");
            double costPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter Selling Price: ");
            double sellingPrice = double.Parse(Console.ReadLine());

            double profit = sellingPrice - costPrice;
            double profitPercent = (profit / costPrice) * 100;

            Console.WriteLine(
               $"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice}\n" +
               $"The Profit is INR {profit} and the Profit Percentage is {profitPercent:F2}%"
           );
        }
    }
}