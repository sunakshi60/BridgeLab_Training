using System;

namespace PracticeQues
{
    internal static class NumberCheckerPart5
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int[] factors = FindFactors(number);
            Console.Write("Factors: ");
            foreach (int factor in factors)
            {
                Console.Write(factor + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Greatest Factor = {FindGreatestFactor(factors)}");
            Console.WriteLine($"Sum of Factors = {FindSumOfFactors(factors)}");
            Console.WriteLine($"Product of Factors = {FindProductOfFactors(factors)}");
            Console.WriteLine($"Product of Cubes of Factors = {FindProductOfCubes(factors)}");
            Console.WriteLine($"Perfect Number = {IsPerfectNumber(number)}");
            Console.WriteLine($"Abundant Number = {IsAbundantNumber(number)}");
            Console.WriteLine($"Deficient Number = {IsDeficientNumber(number)}");
            Console.WriteLine($"Strong Number = {IsStrongNumber(number)}");
        }

        public static int[] FindFactors(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            int[] factors = new int[count];
            int index = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factors[index++] = i;
                }
            }
            return factors;
        }

        public static int FindGreatestFactor(int[] factors)
        {
            return factors[factors.Length - 1];
        }

        public static int FindSumOfFactors(int[] factors)
        {
            int sum = 0;
            foreach (int factor in factors)
            {
                sum += factor;
            }
            return sum;
        }

        public static long FindProductOfFactors(int[] factors)
        {
            long product = 1;
            foreach (int factor in factors)
            {
                product *= factor;
            }
            return product;
        }

        public static double FindProductOfCubes(int[] factors)
        {
            double product = 1;
            foreach (int factor in factors)
            {
                product *= Math.Pow(factor, 3);
            }
            return product;
        }

        public static bool IsPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }

        public static bool IsAbundantNumber(int number)
        {
            int sum = 0;
           for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum > number;
        }

        public static bool IsDeficientNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum < number;
        }

        public static bool IsStrongNumber(int number)
        {
            int temp = number;
            int sum = 0;
            while (temp > 0)
            {
                int digit = temp % 10;
                sum += Factorial(digit);
                temp /= 10;
            }
            return sum == number;
        }

        public static int Factorial(int number)
        {
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}