using System;

namespace PracticeProblems
{
    class ArrayHandler
    {
        public void GetValue(int[] numbers, int index)
        {
            try
            {
                int value = numbers[index];
                Console.WriteLine($"Value at index {index} : {value}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid index!");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Array not initilized!");
            }
        }
    }
}