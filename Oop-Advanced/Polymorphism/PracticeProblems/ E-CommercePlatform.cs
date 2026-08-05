using System;

namespace PracticeProblems
{
    interface ITaxable
    {
        double CalculateTax();
        void GetTaxDetails();
    }
    abstract class Product
    {
        private int productId;
        private string name;
        private double price;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(int id, string name, double price)
        {
            ProductId = id;
            Name = name;
            Price = price;
        }

        public abstract double CalculateDiscount();

        public void DisplayDetails()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Product ID : {ProductId}");
            Console.WriteLine($"Name       : {Name}");
            Console.WriteLine($"Price      : {Price}");
        }
    }

    class Electronics : Product, ITaxable
    {
        public Electronics(int id, string name, double price)
            : base(id, name, price)
        {
        }
        public override double CalculateDiscount()
        {
            return Price * 0.10;
        }

        public double CalculateTax()
        {
            return Price * 0.18;
        }
        public void GetTaxDetails()
        {
            Console.WriteLine($"Tax (18%) : {CalculateTax()}");
        }
    }

    class Clothing : Product, ITaxable
    {
        public Clothing(int id, string name, double price)
            : base(id, name, price)
        {
        }
        public override double CalculateDiscount()
        {
            return Price * 0.15;
        }

        public double CalculateTax()
        {
            return Price * 0.12;
        }

        public void GetTaxDetails()
        {
            Console.WriteLine($"Tax (12%)      : {CalculateTax()}");
        }
    }

    class Groceries : Product
    {
        public Groceries(int id, string name, double price)
            : base(id, name, price)
        {
        }

        public override double CalculateDiscount()
        {
            return Price * 0.05;
        }
    }
}