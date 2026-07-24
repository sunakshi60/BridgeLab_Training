using System;

namespace PracticeQues
{
    internal static class UniversityFeeDiscountInput
    {
        public static void Run()
        {
            Console.Write("Enter Course Fee: ");
            double fee = double.Parse(Console.ReadLine());

            Console.Write("Enter Discount Percentage: ");
            double discountPercent = double.Parse(Console.ReadLine());

            double discount = (fee * discountPercent) / 100;
            double finalFee = fee - discount;

            Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {finalFee:F2}");
        }
    }
}