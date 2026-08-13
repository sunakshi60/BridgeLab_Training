using System;

namespace ScenerioBasedQues
{
    public class InvoiceGenerator
    {
        public static string[] ParseInvoice(string input)
        {
            string[] tasks = input.Split(',');
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = tasks[i].Trim();
            }
            return tasks;
        }

        public static double GetTotalAmount(string[] tasks)
        {
            double total = 0;

            foreach (string task in tasks)
            {
                string[] parts = task.Split('-');

                string amountPart = parts[1].Trim();

                amountPart = amountPart.Replace("INR", "").Trim();

                double amount = Convert.ToDouble(amountPart);

                total += amount;
            }

            return total;
        }

        public static void DisplayInvoice(string[] tasks)
        {
            Console.WriteLine("\n----- INVOICE -----");

            foreach (string task in tasks)
            {
                string[] parts = task.Split('-');

                string taskName = parts[0].Trim();

                string amount = parts[1].Trim();

                Console.WriteLine(taskName + " : " + amount);
            }
        }
    }
}