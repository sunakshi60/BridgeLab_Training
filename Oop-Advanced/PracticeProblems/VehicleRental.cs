using System;

namespace PracticeProblems
{
    interface IRentable
    {
        double CalculateRent(int days);
    }

    class Vehicle : IRentable
    {
        protected string vehicleNumber;
        protected string brand;
        protected double rentPerDay;

        public Vehicle(string vehicleNumber, string brand, double rentPerDay)
        {
            this.vehicleNumber = vehicleNumber;
            this.brand = brand;
            this.rentPerDay = rentPerDay;
        }

        public virtual double CalculateRent(int days)
        {
            return rentPerDay * days;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Vehicle Number: {vehicleNumber}");
            Console.WriteLine($"Brand: {brand}");
        }
    }

    class Bike : Vehicle
    {
        public Bike(string vehicleNumber, string brand, double rentPerDay)
            : base(vehicleNumber, brand, rentPerDay)
        {
        }

        public override double CalculateRent(int days)
        {
            return base.CalculateRent(days);
        }
    }

    class Car : Vehicle
    {
        public Car(string vehicleNumber, string brand, double rentPerDay)
            : base(vehicleNumber, brand, rentPerDay)
        {
        }

        public override double CalculateRent(int days)
        {
            return base.CalculateRent(days) + 500;
        }
    }

    class Truck : Vehicle
    {
        public Truck(string vehicleNumber,string brand,double rentPerDay)
            : base(vehicleNumber, brand, rentPerDay)
        {
        }

        public override double CalculateRent(int days)
        {
            return base.CalculateRent(days) + 1000;
        }
    }

    class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }

        public Customer(int customerId, string name)
        {
            CustomerId = customerId;
            Name = name;
        }
    }
}