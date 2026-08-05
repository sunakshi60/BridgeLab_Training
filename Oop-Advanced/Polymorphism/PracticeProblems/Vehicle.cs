using System;

namespace PracticeProblems
{
    interface IGPS
    {
        void UpdateLocation(string location);
        void GetCurrentLocation();
    }

    abstract class RideVehicle
    {
        private int vehicleId;
        private string driverName;
        private double ratePerKm;

        public int VehicleId
        {
            get { return vehicleId; }
            set { vehicleId = value; }
        }

        public string DriverName
        {
            get { return driverName; }
            set { driverName = value; }
        }

        public double RatePerKm
        {
            get { return ratePerKm; }
            set { ratePerKm = value; }
        }

        public RideVehicle(int id, string driverName, double ratePerKm)
        {
            VehicleId = id;
            DriverName = driverName;
            RatePerKm = ratePerKm;
        }

        public abstract double CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Vehicle ID : {VehicleId}");
            Console.WriteLine($"Driver     : {DriverName}");
            Console.WriteLine($"Rate/Km    : {RatePerKm}");
        }
    }

    class CarType : RideVehicle, IGPS
    {
        private string currentLocation;

        public CarType(int id, string driverName, double rate)
            : base(id, driverName, rate)
        {
        }

        public override double CalculateFare(double distance)
        {
            return RatePerKm * distance;
        }

        public void UpdateLocation(string location)
        {
            currentLocation = location;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine($"Current Location : {currentLocation}");
        }
    }

    class BikeType : RideVehicle, IGPS
    {
        private string currentLocation;

        public BikeType(int id, string driverName, double rate)
            : base(id, driverName, rate)
        {
        }

        public override double CalculateFare(double distance)
        {
            return (RatePerKm * distance) + 20;
        }

        public void UpdateLocation(string location)
        {
            currentLocation = location;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine($"Current Location : {currentLocation}");
        }
    }

    class AutoType : RideVehicle, IGPS
    {
        private string currentLocation;

        public AutoType(int id, string driverName, double rate)
            : base(id, driverName, rate)
        {
        }

        public override double CalculateFare(double distance)
        {
            return (RatePerKm * distance) + 30;
        }

        public void UpdateLocation(string location)
        {
            currentLocation = location;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine($"Current Location : {currentLocation}");
        }
    }
}