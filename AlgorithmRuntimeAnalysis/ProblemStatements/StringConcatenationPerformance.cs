using System;
using System.Diagnostics;
using System.Text;

namespace ProblemsStatements
{
    public class StringConcatenationPerformance
    {
        public static void Run()
        {
            int[] operationCounts = { 1000, 10000, 100000, 1000000 };

            Console.WriteLine(
                "{0,-20}{1,-25}{2,-25}",
                "Operations",
                "String",
                "StringBuilder"
            );

            Console.WriteLine(new string('-', 70));

            foreach (int count in operationCounts)
            {
                Stopwatch stringWatch = Stopwatch.StartNew();

                string result = "";

                for (int i = 0; i < count; i++)
                {
                    result += "A";
                }

                stringWatch.Stop();

                Stopwatch builderWatch = Stopwatch.StartNew();

                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < count; i++)
                {
                    builder.Append("A");
                }

                string finalResult = builder.ToString();

                builderWatch.Stop();

                Console.WriteLine(
                    "{0,-20}{1,-25}{2,-25}",
                    count,
                    stringWatch.Elapsed.TotalMilliseconds + " ms",
                    builderWatch.Elapsed.TotalMilliseconds + " ms"
                );
            }
        }
    }
}