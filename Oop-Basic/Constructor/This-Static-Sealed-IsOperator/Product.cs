using System;

namespace This_Static_Sealed_IsOperator
{
  class Product
    {
        static double discount = 10;
        public readonly int productID;
        string productName;
        double price;
        int quantity;
        public Product(int productID, string productName, double price, int quantity)
        {
            this.productID = productID;
            this.productName = productName;
            this.price = price;
            this.quantity = quantity;
        }
        public void DisplayProductDetails()
        {
            double totalPrice = price * quantity;
            double finalPrice = totalPrice - (totalPrice * discount / 100);

            Console.WriteLine("\nProduct Details");
            Console.WriteLine("Product ID   : " + productID);
            Console.WriteLine("Product Name : " + productName);
            Console.WriteLine("Price        : " + price);
            Console.WriteLine("Quantity     : " + quantity);
            Console.WriteLine("Discount     : " + discount + "%");
            Console.WriteLine("Final Price  : " + finalPrice);
        }
        public static void UpdateDiscount(double newDiscount)
        {
            discount = newDiscount;
        }
    }
}