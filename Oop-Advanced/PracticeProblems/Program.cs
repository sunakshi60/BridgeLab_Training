using System;

namespace PracticeProblems
{
    class Program
    {
        static void Main()
        {
            //Patient p1 = new InPatient(1, "Rahul", 45, 101, 5);
            //Patient p2 = new OutPatient(2, "Aman", 30, "20-Aug-2026");
            //p1.DisplayInfo();
            //Console.WriteLine();
            //p2.DisplayInfo();
            //Console.WriteLine();
            //Doctor doctor = new Doctor(101, "Dr. Sharma", "Cardiologist");
            //doctor.DisplayDoctor();
            //Console.WriteLine();
            //IPayable bill = new Bill(5001, 15000);
            //bill.PayBill();


            //Vehicle bike = new Bike("PB01AB1234", "Honda", 500);
            //Vehicle car = new Car("PB02CD5678", "Toyota", 2000);
            //Vehicle truck = new Truck("PB03EF9012", "Tata", 4000);
            //int days = 3;
            //Console.WriteLine($"Bike Rent: Rs.{bike.CalculateRent(days)}");
            //Console.WriteLine($"Car Rent: Rs.{car.CalculateRent(days)}");
            //Console.WriteLine($"Truck Rent: Rs.{truck.CalculateRent(days)}");


            Bird[] birds =
        {
            new Eagle("Eagle-1"),
            new Sparrow("Sparrow-1"),
            new Duck("Duck-1"),
            new Penguin("Penguin-1"),
            new Seagull("Seagull-1")
        };

            foreach (Bird bird in birds)
            {
                bird.DisplayInfo();

                if (bird is IFlyable flyable)
                {
                    flyable.Fly();
                }
                if (bird is ISwimmable swimmable)
                {
                    swimmable.Swim();
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}