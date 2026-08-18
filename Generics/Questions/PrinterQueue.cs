using System;
using System.Collections.Generic;

namespace Questions
{
    public class PrintJob
    {
        public int JobId { get; set; }
        public string DocumentName { get; set; }
        public int NumberOfPages { get; set; }

        public PrintJob(int jobId, string documentName, int numberOfPages)
        {
            JobId = jobId;
            DocumentName = documentName;
            NumberOfPages = numberOfPages;
        }

        public void Display()
        {
            Console.WriteLine(
                $"Job ID: {JobId}, Document: {DocumentName}, Pages: {NumberOfPages}"
            );
        }
    }

    public class PrinterQueue
    {
        private Queue<PrintJob> printJobs;

        public PrinterQueue()
        {
            printJobs = new Queue<PrintJob>();
        }

        public bool IsBalanced(string text)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in text)
            {
                if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    stack.Pop();
                }
            }

            return stack.Count == 0;
        }

        public bool AddJob(PrintJob job)
        {
            if (!IsBalanced(job.DocumentName))
            {
                return false;
            }

            printJobs.Enqueue(job);
            return true;
        }

        public void ProcessNextJob()
        {
            if (printJobs.Count == 0)
            {
                Console.WriteLine("No pending print jobs.");
                return;
            }

            PrintJob job = printJobs.Dequeue();

            Console.WriteLine("\nProcessing Print Job:");
            job.Display();
        }

        public void DisplayPendingJobs()
        {
            if (printJobs.Count == 0)
            {
                Console.WriteLine("No pending print jobs.");
                return;
            }

            Console.WriteLine("\nPending Print Jobs:");

            foreach (PrintJob job in printJobs)
            {
                job.Display();
            }
        }

        public void ValidateDocument(string documentName)
        {
            if (IsBalanced(documentName))
            {
                Console.WriteLine("Parentheses are balanced.");
            }
            else
            {
                Console.WriteLine("Parentheses are NOT balanced.");
            }
        }
    }
}