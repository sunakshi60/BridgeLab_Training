using System;

namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog("Tommy", 3);
            //Cat cat = new Cat("Kitty", 2);
            //Bird bird = new Bird("Tweety", 1);
            //Console.WriteLine("===== DOG =====");
            //dog.DisplayInfo();
            //dog.MakeSound();
            //Console.WriteLine();
            //Console.WriteLine("===== CAT =====");
            //cat.DisplayInfo();
            //cat.MakeSound();
            //Console.WriteLine();
            //Console.WriteLine("===== BIRD =====");
            //bird.DisplayInfo();
            //bird.MakeSound();

            //Manager manager = new Manager("Rahul", 101, 80000, 12);
            //Developer developer = new Developer("Priya", 102, 60000, "C#");
            //Intern intern = new Intern("Aman", 103, 15000, "6 Months");
            //Console.WriteLine("===== Manager Details =====");
            //manager.DisplayDetails();
            //Console.WriteLine();
            //Console.WriteLine("===== Developer Details =====");
            //developer.DisplayDetails();
            //Console.WriteLine();
            //Console.WriteLine("===== Intern Details =====");
            //intern.DisplayDetails();

            //Vehicle[] vehicles =
            //{
            //    new Car(220, "Petrol", 5),
            //    new Truck(140, "Diesel", 12000),
            //    new Motorcycle(180, "Petrol", false)
            //};
            //foreach (Vehicle vehicle in vehicles)
            //{
            //    vehicle.DisplayInfo();
            //    Console.WriteLine();
            //}

            //Author author = new Author(
            //    "The Alchemist",
            //    1988,
            //    "Paulo Coelho",
            //    "Brazilian novelist"
            //);
            //author.DisplayInfo();

            //Thermostat thermostat = new Thermostat(101, "Active", 24);
            //thermostat.DisplayStatus();

            //DeliveredOrder order = new DeliveredOrder(
            //    101,
            //    "04-Aug-2026",
            //    "TRK123456",
            //    "06-Aug-2026"
            //);
            //order.GetOrderStatus();

            //PaidOnlineCourse course = new PaidOnlineCourse(
            //    "C# Programming",
            //    6,
            //    "Udemy",
            //    true,
            //    5000,
            //    20
            //);
            //course.DisplayCourseDetails();

            //SavingsAccount savings = new SavingsAccount(1001, 50000, 6.5);
            //CheckingAccount checking = new CheckingAccount(1002, 30000, 10000);
            //FixedDepositAccount fixedDeposit = new FixedDepositAccount(1003, 100000, 5);
            //savings.DisplayAccountType();
            //Console.WriteLine();
            //checking.DisplayAccountType();
            //Console.WriteLine();
            //fixedDeposit.DisplayAccountType();

            //Teacher teacher = new Teacher("Anita", 35, "Mathematics");
            //Student student = new Student("Rahul", 18, "12th");
            //Staff staff = new Staff("Suresh", 40, "Administration");
            //teacher.DisplayRole();
            //Console.WriteLine();
            //student.DisplayRole();
            //Console.WriteLine();
            //staff.DisplayRole();

            //Chef chef = new Chef("Rahul", 101, "Paneer Butter Masala");
            //Waiter waiter = new Waiter("Aman", 102, "VIP Hall");
            //Console.WriteLine("===== Chef =====");
            //chef.DisplayInfo();
            //chef.PerformDuties();
            //Console.WriteLine();
            //Console.WriteLine("===== Waiter =====");
            //waiter.DisplayInfo();
            //waiter.PerformDuties();

            ElectricVehicle electric = new ElectricVehicle(220, "Tesla Model 3");
            PetrolVehicle petrol = new PetrolVehicle(180, "Honda City");
            Console.WriteLine("===== Electric Vehicle =====");
            electric.DisplayInfo();
            electric.Charge();
            Console.WriteLine();
            Console.WriteLine("===== Petrol Vehicle =====");
            petrol.DisplayInfo();
            petrol.Refuel();


            Console.ReadLine();
        }
    }
}
