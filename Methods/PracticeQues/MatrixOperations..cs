using System;

namespace PracticeQues
{
    internal static class MatrixOperations
    {
        public static void Run()
        {
            Console.Write("Enter number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter number of columns: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix1 = CreateRandomMatrix(rows, columns);
            int[,] matrix2 = CreateRandomMatrix(rows, columns);
            Console.WriteLine("\nMatrix 1:");
            DisplayMatrix(matrix1);
            Console.WriteLine("\nMatrix 2:");
            DisplayMatrix(matrix2);
            Console.WriteLine("\nAddition:");
            DisplayMatrix(AddMatrices(matrix1, matrix2));
            Console.WriteLine("\nSubtraction:");
            DisplayMatrix(SubtractMatrices(matrix1, matrix2));
            if (matrix1.GetLength(1) == matrix2.GetLength(0))
            {
                Console.WriteLine("\nMultiplication:");
                DisplayMatrix(MultiplyMatrices(matrix1, matrix2));
            }
            else
            {
                Console.WriteLine("\nMatrix Multiplication is not possible.");
            }
            Console.WriteLine("\nTranspose of Matrix 1:");
            DisplayMatrix(TransposeMatrix(matrix1));
            if (rows == 2 && columns == 2)
            {
                Console.WriteLine($"\nDeterminant = {Determinant2x2(matrix1):F2}");
                Console.WriteLine("\nInverse:");
                DisplayDoubleMatrix(Inverse2x2(matrix1));
            }
            else if (rows == 3 && columns == 3)
            {
                Console.WriteLine($"\nDeterminant = {Determinant3x3(matrix1):F2}");
            }
        }

        public static int[,] CreateRandomMatrix(int rows, int columns)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(1, 10);
                }
            }
            return matrix;
        }

        public static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

        public static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix1.GetLength(1);
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;
        }

        public static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int columns = matrix2.GetLength(1);
            int common = matrix1.GetLength(1);
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    for (int k = 0; k < common; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }

        public static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            int[,] transpose = new int[columns, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }
            return transpose;
        }

        public static double Determinant2x2(int[,] matrix)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        public static double Determinant3x3(int[,] matrix)
        {
            return matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])- matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])+ matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        }

        public static double[,] Inverse2x2(int[,] matrix)
        {
            double determinant = Determinant2x2(matrix);
            double[,] inverse = new double[2, 2];
            if (determinant == 0)
            {
                return inverse;
            }
            inverse[0, 0] = matrix[1, 1] / determinant;
            inverse[0, 1] = -matrix[0, 1] / determinant;
            inverse[1, 0] = -matrix[1, 0] / determinant;
            inverse[1, 1] = matrix[0, 0] / determinant;
            return inverse;
        }

        public static void DisplayMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void DisplayDoubleMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]:F2}\t");
                }
                Console.WriteLine();
            }
        }
    }
}