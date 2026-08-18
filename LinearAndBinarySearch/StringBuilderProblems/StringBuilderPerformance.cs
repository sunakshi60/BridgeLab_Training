using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilderProblems
{
    public class StringBuilderPerformance
    {
        public static void Run()
        {
            int iterations = 100000;

            // StringBuilder
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < iterations; i++)
            {
                sb.Append("Hello ");
            }

            stopwatch.Stop();
            Console.WriteLine("Iterations: " + iterations);
            Console.WriteLine("Time taken by StringBuilder: "+ stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}