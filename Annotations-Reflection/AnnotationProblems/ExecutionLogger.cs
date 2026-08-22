using System;
using System.Diagnostics;

namespace AnnotationProblems
{
    [AttributeUsage(AttributeTargets.Method)]
    class LogExecutionTime : Attribute
    {
    }

    class PerformanceTest
    {
        [LogExecutionTime]
        public void FastMethod()
        {
            for (int i = 0; i < 100000; i++)
            {
                int x = i * i;
            }
        }

        [LogExecutionTime]
        public void SlowMethod()
        {
            for (int i = 0; i < 10000000; i++)
            {
                int x = i * i;
            }
        }

        public void NormalMethod()
        {
            Console.WriteLine("This method is not measured.");
        }
    }
}