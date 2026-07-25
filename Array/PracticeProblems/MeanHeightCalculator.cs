using System;

namespace PracticeProblems
{
    internal class MeanHeightCalculator
    {
        public static void Run()
        {
            double[] Players = new double[11];
            
            for(int i = 0; i < Players.Length; i++)
            {
                Console.Write($"Please enter height of player Number {i+1}: ");
                Players[i] = double.Parse(Console.ReadLine());
            }
            double Mean = 0;
            double Sum = 0L;
            for(int i = 0; i < Players.Length; i++)
            {
                Sum += Players[i];
            }
            Mean = Sum / 11;
            Console.WriteLine($"Mean height of football team is : {Mean}");
        }

        
    }
}