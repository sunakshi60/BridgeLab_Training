using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    //Abstract Products
    public interface IBike
    {
        void GetDetails();
    }
    public interface ICar
    {
        void GetDetails();
    }

    //Concrete Products
    public class RegularBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Regular Bike Details");
        }
    }

    public class SportsBike : IBike
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Sports Bike Details");
        }
    }

    public class RegularCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Regular Car Details");
        }
    }

    public class SportsCar : ICar
    {
        public void GetDetails()
        {
            Console.WriteLine("Fetching Sports Car Details");
        }
    }

    //Abstract Factory
    public interface IVehicleFactory
    {
        IBike CreateBike();
        ICar CreateCar();
    }

    //Concrete Factory
    public class RegularVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new RegularBike();
        }

        public ICar CreateCar()
        {
            return new RegularCar();
        }
    }

    public class SportsVehicleFactory : IVehicleFactory
    {
        public IBike CreateBike()
        {
            return new SportsBike();
        }

        public ICar CreateCar()
        {
            return new SportsCar();
        }
    }
}
