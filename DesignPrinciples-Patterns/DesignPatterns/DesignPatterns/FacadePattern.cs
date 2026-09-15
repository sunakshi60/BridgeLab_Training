using System;

namespace DesignPatterns
{
    //Product subsystem
    public class Product
    {
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching Product Details");
        }
    }

    //Payment Subsystem
    public class Payment
    {
        public void MakePayment()
        {
            Console.WriteLine("Payment Done Successfully");
        }
    }

    //Invoice Subsystem
    public class Invoice
    {
        public void SendInvoice()
        {
            Console.WriteLine("Invoice Sent Successfully");
        }
    }

    //Facade 
    public class Order
    {
        public void PlaceOrder()
        {
            Console.WriteLine("Place Order Started");

            Product product = new Product();
            product.GetProductDetails();

            Payment payment = new Payment();
            payment.MakePayment();

            Invoice invoice = new Invoice();
            invoice.SendInvoice();

            Console.WriteLine("Order Placed Successfully");
        }
    }
}