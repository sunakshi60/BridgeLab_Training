using System;

namespace PracticeProblems
{
    internal class TwoDArrayToOneDArray
    {
        public static void Run()
        {
            Console.WriteLine("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, columns];
            Console.WriteLine("Enter matrix elements: ");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Element at {i},{j}: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[] array = new int[rows * columns];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[index++] = matrix[i, j];
                }
            }

            Console.WriteLine("\n2D array: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
           
            Console.WriteLine("1D Array");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
