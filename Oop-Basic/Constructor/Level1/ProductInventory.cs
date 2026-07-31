using System;

namespace InstanceAndClassQues
{
    class Product
    {
        string productName;
        double price;

        static int totalProducts = 0;

        public Product(string productName,double price)
        {
            this.productName = productName;
            this.price = price;
            totalProducts++;
        }

        public void DisplayProductDetails()
        {
            Console.WriteLine("\nProduct Name: " + productName);
            Console.WriteLine("Price : " + price);
        }

        public static void DisplayTotalProducts()
        {
            Console.WriteLine("\nTotal Products Created : " + totalProducts);
        }

    }
}