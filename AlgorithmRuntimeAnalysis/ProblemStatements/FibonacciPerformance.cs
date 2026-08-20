using System;
using System.Diagnostics;

namespace ProblemsStatements
{
    public class FibonacciPerformance
    {
        public static void Run()
        {
            int[] values = { 10, 20, 30, 40 };

            Console.WriteLine(
                "{0,-15}{1,-25}{2,-25}",
                "N",
                "Recursive",
                "Iterative"
            );

            Console.WriteLine(new string('-', 65));

            foreach (int n in values)
            { 
                Stopwatch recursiveWatch = Stopwatch.StartNew();

                long recursiveResult = FibonacciRecursive(n);

                recursiveWatch.Stop();

                Stopwatch iterativeWatch = Stopwatch.StartNew();

                long iterativeResult = FibonacciIterative(n);

                iterativeWatch.Stop();

                Console.WriteLine(
                    "{0,-15}{1,-25}{2,-25}",
                    n,
                    recursiveWatch.Elapsed.TotalMilliseconds + " ms",
                    iterativeWatch.Elapsed.TotalMilliseconds + " ms"
                );

                Console.WriteLine($"Fibonacci({n}) = {iterativeResult}");

                Console.WriteLine();
            }
        }

        private static long FibonacciRecursive(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return FibonacciRecursive(n - 1)+ FibonacciRecursive(n - 2);
        }

        private static long FibonacciIterative(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            long a = 0;
            long b = 1;

            for (int i = 2; i <= n; i++)
            {
                long sum = a + b;

                a = b;
                b = sum;
            }

            return b;
        }
    }
}