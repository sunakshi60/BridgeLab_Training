using System;
using System.Collections.Generic;

namespace PracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> employees = new List<Employee>();
            //FullTimeEmployee emp1 = new FullTimeEmployee(101, "Rahul", 50000);
            //emp1.AssignDepartment("IT");
            //PartTimeEmployee emp2 = new PartTimeEmployee(102, "Priya", 300, 80);
            //emp2.AssignDepartment("HR");
            //employees.Add(emp1);
            //employees.Add(emp2);
            //foreach (Employee emp in employees)
            //{
            //    emp.DisplayDetails();
            //    if (emp is IDepartment dept)
            //    {
            //        dept.GetDepartmentDetails();
            //    }
            //    Console.WriteLine();
            //}


            //List<Product> products = new List<Product>();
            //products.Add(new Electronics(101, "Laptop", 60000));
            //products.Add(new Clothing(102, "Jacket", 3000));
            //products.Add(new Groceries(103, "Rice", 1200));
            //foreach (Product product in products)
            //{
            //    product.DisplayDetails();
            //    double tax = 0;
            //    if (product is ITaxable taxable)
            //    {
            //        tax = taxable.CalculateTax();
            //        taxable.GetTaxDetails();
            //    }
            //    else
            //    {
            //        Console.WriteLine("Tax : No Tax");
            //    }
            //    double discount = product.CalculateDiscount();
            //    Console.WriteLine($"Discount      : {discount}");
            //    Console.WriteLine($"Final Price   : {product.Price + tax - discount}");
            //    Console.WriteLine();      
            //}


            //List<Vehicle> vehicles = new List<Vehicle>();
            //vehicles.Add(new Car("HP12A1234", 2000, "CAR101"));
            //vehicles.Add(new Bike("HP12B5678", 800, "BIKE201"));
            //vehicles.Add(new Truck("HP12T9999", 5000, "TRUCK301"));
            //int rentalDays = 5;
            //foreach (Vehicle vehicle in vehicles)
            //{
            //    vehicle.DisplayDetails();
            //    Console.WriteLine($"Rental Days   : {rentalDays}");
            //    Console.WriteLine($"Rental Cost   : {vehicle.CalculateRentalCost(rentalDays)}");
            //    if (vehicle is IInsurable insurance)
            //    {
            //        insurance.GetInsuranceDetails();
            //    }
            //    Console.WriteLine();
            //}


            //List<BankAccount> accounts = new List<BankAccount>();
            //SavingsAccount acc1 = new SavingsAccount("SB101", "Rahul", 50000);
            //CurrentAccount acc2 = new CurrentAccount("CA201", "Priya", 80000);
            //acc1.Deposit(5000);
            //acc2.Withdraw(10000);
            //accounts.Add(acc1);
            //accounts.Add(acc2);
            //foreach (BankAccount account in accounts)
            //{
            //    account.DisplayDetails();
            //    Console.WriteLine($"Interest : {account.CalculateInterest()}");
            //    if (account is ILoanable loan)
            //    {
            //        loan.ApplyForLoan();
            //        Console.WriteLine($"Loan Eligibility : {loan.CalculateLoanEligibility()}");
            //    }
            //    Console.WriteLine();
            //}


            //List<LibraryItem> items = new List<LibraryItem>();
            //Book book = new Book(101, "C# Programming", "John");
            //Magazine magazine = new Magazine(102, "Tech Monthly", "David");
            //DVD dvd = new DVD(103, "Avengers", "Marvel");
            //items.Add(book);
            //items.Add(magazine);
            //items.Add(dvd);
            // foreach (LibraryItem item in items)
            //{
            //    item.GetItemDetails();
            //    Console.WriteLine($"Loan Duration : {item.GetLoanDuration()} Days");
            //    if (item is IReservable reservable)
            //    {
            //        Console.WriteLine($"Available : {reservable.CheckAvailability()}");
            //        reservable.ReserveItem();
            //        Console.WriteLine($"Available : {reservable.CheckAvailability()}");
            //    }
            //    Console.WriteLine();
            //}

            //List<FoodItem> foodItems = new List<FoodItem>();
            //foodItems.Add(new VegItem("Paneer Pizza", 250, 2));
            //foodItems.Add(new NonVegItem("Chicken Burger", 180, 3));
            //foreach (FoodItem item in foodItems)
            //{
            //    item.GetItemDetails();
            //    double totalPrice = item.CalculateTotalPrice();
            //    Console.WriteLine($"Total Price : {totalPrice}");
            //    if (item is IDiscountable discount)
            //    {
            //        discount.GetDiscountDetails();
            //        Console.WriteLine($"Final Price : {totalPrice - discount.ApplyDiscount()}");
            //    }
            //    Console.WriteLine();
            //}

            //List<Patient> patients = new List<Patient>();
            //InPatient patient1 = new InPatient(101, "Rahul", 30, 5, 2000);
            //patient1.AddRecord("Typhoid", "Admitted for fever");
            //OutPatient patient2 = new OutPatient(102, "Priya", 25, 800);
            //patient2.AddRecord("Cold", "General Checkup");
            //patients.Add(patient1);
            //patients.Add(patient2);
            //foreach (Patient patient in patients)
            //{
            //    patient.GetPatientDetails();
            //    if (patient is IMedicalRecord record)
            //    {
            //        record.ViewRecords();
            //    }
            //    Console.WriteLine($"Total Bill : {patient.CalculateBill()}");
            //    Console.WriteLine();
            //}

            List<RideVehicle> vehicles = new List<RideVehicle>();
            CarType c = new CarType(101, "Rahul", 15);
            c.UpdateLocation("Chandigarh");
            BikeType b = new BikeType(102, "Priya", 10);
            b.UpdateLocation("Mohali");
            AutoType a = new AutoType(103, "Amit", 12);
            a.UpdateLocation("Zirakpur");
            vehicles.Add(c);
            vehicles.Add(b);
            vehicles.Add(a);
            double distance = 10;
            foreach (RideVehicle vehicle in vehicles)
            {
                vehicle.GetVehicleDetails();

                if (vehicle is IGPS gps)
                {
                    gps.GetCurrentLocation();
                }
                Console.WriteLine($"Distance : {distance} km");
                Console.WriteLine($"Fare     : {vehicle.CalculateFare(distance)}");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
