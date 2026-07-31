using System;

namespace InstanceAndClassQues
{
    class Vehicle
    {
        string ownerName;
        string vehicleType;

        static double registrationFee = 2500;

        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        public void DisplayVehicleDetails()
        {
            Console.WriteLine("\nOwner Name      : " + ownerName);
            Console.WriteLine("Vehicle Type    : " + vehicleType);
            Console.WriteLine("Registration Fee: " + registrationFee);
        }


        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
        }
    }
}