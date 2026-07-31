using System;

namespace Level1
{
    class CarRental
    {
        string customerName;
        string carModel;
        int rentalDays;

        public CarRental()
        {
            customerName = "unknown";
            carModel = "Swift";
            rentalDays = 1;
        }

        public CarRental(string customerName,string carModel,int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
        }

        public double CalculateCost()
        {
            double rentPerDay = 1500;
            return rentalDays * rentPerDay;
        }

        public void Display()
        {
            Console.WriteLine("Customer Name : " + customerName);
            Console.WriteLine("Car Model : " + carModel);
            Console.WriteLine("Rental Days : " + rentalDays);
            Console.WriteLine("Total Cost : " + CalculateCost());
        }
    }
}