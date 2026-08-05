using System;

namespace PracticeProblems
{
    interface IDiscountable
    {
        double ApplyDiscount();
        void GetDiscountDetails();
    }

    abstract class FoodItem
    {
        private string itemName;
        private double price;
        private int quantity;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public FoodItem(string itemName, double price, int quantity)
        {
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
        }

        public abstract double CalculateTotalPrice();

        public void GetItemDetails()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Item Name : {ItemName}");
            Console.WriteLine($"Price     : {Price}");
            Console.WriteLine($"Quantity  : {Quantity}");
        }
    }

    class VegItem : FoodItem, IDiscountable
    {
        public VegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity)
        {
        }

        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + 20;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.10;
        }

        public void GetDiscountDetails()
        {
            Console.WriteLine($"Discount (10%) : {ApplyDiscount()}");
        }
    }

    class NonVegItem : FoodItem, IDiscountable
    {
        public NonVegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity)
        {
        }
        public override double CalculateTotalPrice()
        {
            return (Price * Quantity) + 50;
        }

        public double ApplyDiscount()
        {
            return CalculateTotalPrice() * 0.05;
        }

        public void GetDiscountDetails()
        {
            Console.WriteLine($"Discount (5%) : {ApplyDiscount()}");
        }
    }
}