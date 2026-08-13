using System;

namespace ScenerioBasedQues
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Enter invoice tasks: ");
            //string input = Console.ReadLine();
            //string[] tasks = InvoiceGenerator.ParseInvoice(input);
            //InvoiceGenerator.DisplayInvoice(tasks);
            //double total = InvoiceGenerator.GetTotalAmount(tasks);
            //Console.WriteLine("-------------------");
            //Console.WriteLine("Total Amount: " + total + " INR");


            CafeteriaMenu.DisplayMenu();
            Console.Write("\nEnter item index: ");
            int index = Convert.ToInt32(Console.ReadLine());
            string selectedItem = CafeteriaMenu.GetItemByIndex(index);
            Console.WriteLine("You selected: " + selectedItem);

            Console.ReadLine();
        }
    }
}