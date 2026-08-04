using System;

namespace PracticeProblems
{
    interface Refuelable
    {
        void Refuel();
    }
    class VehicleHybrid
    {
        public int MaxSpeed;
        public string Model;

        public VehicleHybrid(int speed,string model)
        {
            MaxSpeed = speed;
            Model = model;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Model : {Model}");
            Console.WriteLine($"Max Speed : {MaxSpeed} km/h");
        }
    }

    class ElectricVehicle : VehicleHybrid
    {
        public ElectricVehicle(int speed,string model) : base(speed, model)
        {

        }

        public void Charge()
        {
            Console.WriteLine("Charging the electric vehicle...");
        }
    }

    class PetrolVehicle : VehicleHybrid, Refuelable
    {
        public PetrolVehicle(int speed, string model): base(speed, model)
        {

        }

        public void Refuel()
        {
            Console.WriteLine("Refueling the petrol vehicle...");
        }
    }
}