using System;

namespace PracticeProblems
{
    interface IInsurable
    {
        double CalculateInsurance();
        void GetInsuranceDetails();
    }

    abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        private double rentalRate;

        public string VehicleNumber
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double RentalRate
        {
            get { return rentalRate; }
            set { rentalRate = value; }
        }
        protected Vehicle(string vehicleNumber, string type, double rentalRate)
        {
            VehicleNumber = vehicleNumber;
            Type = type;
            RentalRate = rentalRate;
        }

        public abstract double CalculateRentalCost(int days);

        public void DisplayDetails()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Vehicle Number : {VehicleNumber}");
            Console.WriteLine($"Type           : {Type}");
            Console.WriteLine($"Rental Rate    : {RentalRate}");
        }
    }

    class Car : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Car(string number, double rate, string policyNumber)
            : base(number, "Car", rate)
        {
            insurancePolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.10;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine($"Insurance Cost : {CalculateInsurance()}");
        }
    }

    class Bike : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;
        public Bike(string number, double rate, string policyNumber)
            : base(number, "Bike", rate)
        {
            insurancePolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.05;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine($"Insurance Cost : {CalculateInsurance()}");
        }
    }

    class Truck : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;
        public Truck(string number, double rate, string policyNumber)
            : base(number, "Truck", rate)
        {
            insurancePolicyNumber = policyNumber;
        }

        public override double CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.15;
        }

        public void GetInsuranceDetails()
        {
            Console.WriteLine($"Insurance Cost : {CalculateInsurance()}");
        }
    }
}