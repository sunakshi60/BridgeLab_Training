using System;

namespace PracticeProblems
{
    public class NestedTryHandler
    {
        public void PerformOperation(int[] numbers, int index, int divisor)
        {
            try
            {
                int value = numbers[index];
                try
                {
                    int result = value / divisor;

                    Console.WriteLine("Division result: " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
        }
    }
}