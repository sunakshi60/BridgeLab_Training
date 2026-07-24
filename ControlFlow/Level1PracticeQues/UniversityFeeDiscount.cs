using System;

namespace PracticeQues
{
    internal static class UniversityFeeDiscount
    {
        public static void Run()
        {
            Console.Write("Enter Course Fee (INR): ");
            double fee = double.Parse(Console.ReadLine());

            Console.Write("Enter Discount Percentage: ");
            double discountPercent = double.Parse(Console.ReadLine());

            double discountAmount = (fee * discountPercent) / 100;
            double finalFee = fee - discountAmount;

            Console.WriteLine(
                $"\nThe discount amount is INR {discountAmount:F2} and final discounted fee is INR {finalFee:F2}."
            );
        }
    }
}