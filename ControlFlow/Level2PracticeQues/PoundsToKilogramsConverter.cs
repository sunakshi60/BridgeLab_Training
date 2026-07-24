using System;

namespace Level2PracticeQues
{
    internal static class PoundsToKilogramsConverter
    {
        public static void Run()
        {
            Console.Write("Enter Weight in Pounds: ");
            double pounds = double.Parse(Console.ReadLine());

            double kilograms = pounds / 2.2;

            Console.WriteLine($"The weight of the person in pounds is {pounds} and in kg is {kilograms:F2}");
        }
    }
}