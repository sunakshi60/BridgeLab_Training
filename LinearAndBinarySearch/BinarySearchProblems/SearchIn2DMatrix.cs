using System;

namespace BinarySearchProblems
{
    public class SearchIn2DMatrix
    {
        public static void Search()
        {
            int[,] matrix =
            {
            { 1, 3, 5, 7 },
            { 10, 11, 16, 20 },
            { 23, 30, 34, 60 }
        };

            Console.Write("Enter target: ");
            int target = Convert.ToInt32(Console.ReadLine());

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                int low = 0;
                int high = columns - 1;

                while (low <= high)
                {
                    int mid = low + (high - low) / 2;

                    if (matrix[row, mid] == target)
                    {
                        Console.WriteLine(
                            $"Target found at row {row}, column {mid}"
                        );
                        return;
                    }
                    else if (matrix[row, mid] < target)
                    {
                        low = mid + 1;
                    }
                    else
                    {
                        high = mid - 1;
                    }
                }
            }

            Console.WriteLine("Target not found.");
        }
    }
}