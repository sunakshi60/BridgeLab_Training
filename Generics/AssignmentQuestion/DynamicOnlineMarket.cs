using System;
using System.Collections.Generic;

namespace AssignmentQuestion
{
    public abstract class Product
    {
        public int Id;
        public string Name;
        public double Price;

        public Product(int id,string name,double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public abstract void DisplayDetails();
    }

    public abstract class ProductCategory
    {
    }
    public class BookCategory : ProductCategory
    {
        public string Author;

        public BookCategory(string author)
        {
            Author = author;
        }
    }

    public class ClothingCategory : ProductCategory
    {
        public string Size;

        public ClothingCategory(string size)
        {
            Size = size;
        }
    }

    public class Product<T> : Product
        where T : ProductCategory
    {
        public T Category;

        public Product(int id,string name,double price,T category) : base(id, name, price)
        {
            Category = category;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Price: Rs.{Price}");
        }
    }
    
    public class ProductCatalog<T> where T : Product
    {
        private List<T> products = new List<T>();

        public void AddProduct(T product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach(T product in products)
            {
                product.DisplayDetails();
            }
        }
    }

    public class Marketplace
    {
        public static void ApplyDiscount<T>(
            T product, double percentage) where T : Product
        {
            double discount = product.Price * percentage / 100;
            product.Price = product.Price - discount;
        }
    }

    public class Question2
    {
        public static void Run()
        {
            Console.WriteLine("\n===== DYNAMIC ONLINE MARKETPLACE =====\n");
            Product<BookCategory> book = new Product<BookCategory>(1, "C# Programming", 1000, new BookCategory("John Smith"));
            Product<ClothingCategory> clothing = new Product<ClothingCategory>(2, "Denim Jacket", 2500, new ClothingCategory("M"));
            Console.WriteLine("--- Original Products ---");
            book.DisplayDetails(); 
            clothing.DisplayDetails();

            Marketplace.ApplyDiscount(book, 10);
            Marketplace.ApplyDiscount(clothing, 20);

            Console.WriteLine("\n--- After Discount ---"); 
            book.DisplayDetails();
            clothing.DisplayDetails();

            Console.WriteLine("\n--- Book Catalog ---");

            ProductCatalog<Product<BookCategory>> bookCatalog = new ProductCatalog<Product<BookCategory>>();
            bookCatalog.AddProduct(book); 
            bookCatalog.DisplayProducts();

            Console.WriteLine("\n--- Clothing Catalog ---");

            ProductCatalog<Product<ClothingCategory>> clothingCatalog = new ProductCatalog<Product<ClothingCategory>>();
            clothingCatalog.AddProduct(clothing);
            clothingCatalog.DisplayProducts();
        }

    }
}