using System;

namespace This_Static_Sealed_IsOperator
{
    class Vehicle
    {
        static double registrationFee = 2500;
        public readonly string registrationNumber;
        string ownerName;
        string vehicleType;

        public Vehicle(string registrationNumber, string ownerName, string vehicleType)
        {
            this.registrationNumber = registrationNumber;
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("\nVehicle Details");
            Console.WriteLine("Registration Number : " + registrationNumber);
            Console.WriteLine("Owner Name          : " + ownerName);
            Console.WriteLine("Vehicle Type        : " + vehicleType);
            Console.WriteLine("Registration Fee    : " + registrationFee);
        }

        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
        }
    }
}