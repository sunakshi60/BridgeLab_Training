using System;

namespace PracticeQues
{
    internal static class PurchaseCalculator
    {
        public static void Run()
        {
            Console.Write("Enter Unit Price: ");
            double unitPrice = double.Parse(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            double totalPrice = unitPrice * quantity;

            Console.WriteLine($"The total purchase price is INR {totalPrice:F2} if the quantity {quantity} and unit price is INR {unitPrice:F2}");
        }
    }
}