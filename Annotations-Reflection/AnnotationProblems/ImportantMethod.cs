using System;

namespace AnnotationProblems
{
    [AttributeUsage(AttributeTargets.Method)]
    class ImportantMethod : Attribute
    {
        public string Level { get; }

        public ImportantMethod(string level = "HIGH")
        {
            Level = level;
        }
    }

    class TaskManager1
    {
        [ImportantMethod]
        public void ProcessPayment()
        {
            Console.WriteLine("Payment processed.");
        }

        [ImportantMethod("MEDIUM")]
        public void GenerateReport()
        {
            Console.WriteLine("Report generated.");
        }

        public void NormalTask()
        {
            Console.WriteLine("Normal task executed.");
        }
    }
}