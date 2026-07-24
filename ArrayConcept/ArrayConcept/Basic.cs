using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayConcept
{
    internal class Basic
    {
        // Demonstrates Single Dimensional Array
        public static void SingleDimensionArray()
        {
            Console.WriteLine("===== Single Dimensional Array =====");

            // Declaration
            int[] marks = new int[5];

            // Declaration + Initialization
            int[] marks2 = { 90, 85, 76, 60, 99 };

            // Explicit Initialization
            int[] marks3 = new int[] { 90, 85, 76 };

            // Accessing an element
            Console.WriteLine("First Element: " + marks2[0]);

            // Modifying an element
            marks2[1] = 88;

            // Length of array
            Console.WriteLine("Length: " + marks2.Length);

            Console.WriteLine("\nUsing For Loop:");
            for (int i = 0; i < marks2.Length; i++)
            {
                Console.Write(marks2[i] + " ");
            }

            Console.WriteLine("\nUsing Foreach Loop:");
            foreach (int item in marks2)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        // Demonstrates Rectangular (2D) Array
        public static void MultiDimensionArray()
        {
            Console.WriteLine("\n===== Multi-Dimensional Array =====");

            int[,] grid =
            {
                {1,2,3},
                {4,5,6}
            };

            Console.WriteLine("Element at [0,1] = " + grid[0, 1]);

            Console.WriteLine("Rows = " + grid.GetLength(0));
            Console.WriteLine("Columns = " + grid.GetLength(1));

            Console.WriteLine("Matrix:");

            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Demonstrates Jagged Array
        public static void JaggedArray()
        {
            Console.WriteLine("\n===== Jagged Array =====");

            int[][] jagged = new int[3][];

            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 5, 6, 7 };
            jagged[2] = new int[] { 9 };

            Console.WriteLine("Element = " + jagged[1][1]);

            Console.WriteLine("Complete Jagged Array:");

            for (int i = 0; i < jagged.Length; i++)
            {
                foreach (int value in jagged[i])
                {
                    Console.Write(value + " ");
                }
                Console.WriteLine();
            }
        }

        // Demonstrates Reference Copy
        public static void CopyArray()
        {
            Console.WriteLine("\n===== Array Copy =====");

            int[] source = { 1, 2, 3 };

            // Reference Copy
            int[] refCopy = source;

            refCopy[0] = 100;

            Console.WriteLine("Source Array:");

            foreach (int item in source)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nReference Copy:");

            foreach (int item in refCopy)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\nBoth arrays point to the same memory location.");
        }
    }
}
