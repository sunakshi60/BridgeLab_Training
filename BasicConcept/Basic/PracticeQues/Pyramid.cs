using System;

namespace PracticeQues
{
    internal class Pattern
    {
        public static int n;

        public static void Accept()
        {
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
        }

        public static void LeftHalfPyramid()
        {
            Console.WriteLine("\nLeft Half Pyramid:");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void RightHalfPyramid()
        {
            Console.WriteLine("\nRight Half Pyramid:");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public static void FullPyramid()
        {
            Console.WriteLine("\nFull Pyramid:");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public static void InvertedFullPyramid()
        {
            Console.WriteLine("\nInverted Full Pyramid:");

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}