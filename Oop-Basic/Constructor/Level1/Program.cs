using AccessModifiersQues;
using System;

namespace Level1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("\nBook Details 1");
            //Book b1 = new Book();
            //b1.Display();
            //Console.WriteLine("\nBook Details 2");
            //Book b2 = new Book("Come! Let's Run", "Subramanian", 456);
            //b2.Display();

            //Console.WriteLine("\nArea of circle 1");
            //Circle c1 = new Circle();
            //c1.Display();
            //Console.WriteLine("\nArea of circle 2");
            //Circle c2 = new Circle(12);
            //c2.Display();

            //Console.WriteLine("\nPerson 1");
            //Person p1 = new Person("Sunakshi",21);
            //p1.Display();
            //Console.WriteLine("\nPerson 2");
            //Person p2 = new Person(p1);
            //p2.Display();

            //Console.WriteLine("\nBook 1");
            //HotelBooking h1 = new HotelBooking();
            //h1.Display();
            //Console.WriteLine("\nBook 2");
            //HotelBooking h2 = new HotelBooking("Reet","High",10);
            //h2.Display();
            //Console.WriteLine("\nBook 3");
            //HotelBooking h3 = new HotelBooking(h2);
            //h2.Display();

            //LibrarySystem l1 = new LibrarySystem("Come! Let's Run", "Subramanian",123);
            //l1.Display();
            //l1.BorrowBook();
            //l1.Display();

            //Console.WriteLine("\nCar 1");
            //CarRental c = new CarRental();
            //c.Display();
            //Console.WriteLine("\nCar 2");
            //CarRental c1 = new CarRental("Rana", "Thar", 13);
            //c1.Display();

            //Console.WriteLine("Product Details");
            //Product p1 = new Product("Laptop", 65000);
            //Product p2 = new Product("Mouse", 800);
            //Product p3 = new Product("Keyboard", 1500);
            //p1.DisplayProductDetails();
            //p2.DisplayProductDetails();
            //p3.DisplayProductDetails();
            //Product.DisplayTotalProducts();

            //Course c1 = new Course("C#", 6, 25000);
            //Course c2 = new Course("Java", 4, 20000);
            //Console.WriteLine("Before Updating Institute Name");
            //c1.DisplayCourseDetails();
            //c2.DisplayCourseDetails();
            //Course.UpdateInstituteName("EasyRewardz Academy");
            //Console.WriteLine("\nAfter Updating Institute Name");
            //c1.DisplayCourseDetails();
            //c2.DisplayCourseDetails();

            //Vehicle v1 = new Vehicle("Sakshi", "Car");
            //Vehicle v2 = new Vehicle("Rahul", "Bike");
            //Console.WriteLine("Before Fee Update");
            //v1.DisplayVehicleDetails();
            //v2.DisplayVehicleDetails();
            //Vehicle.UpdateRegistrationFee(3500);
            //Console.WriteLine("\nAfter Fee Update");
            //v1.DisplayVehicleDetails();
            //v2.DisplayVehicleDetails();


            //PostgraduateStudent s = new PostgraduateStudent(101, "Sunakshi", 8.9);
            //s.Display();
            //s.SetCGPA(9.2);
            //Console.WriteLine("\nAfter Updating CGPA");
            //Console.WriteLine("CGPA : " + s.GetCGPA());

            //EBook book = new EBook("978-12345", "C# Programming", "James");
            //book.Display();
            //book.SetAuthor("Robert");
            //Console.WriteLine("\nAfter Updating Author");
            //book.Display();

            //SavingsAccount account = new SavingsAccount("123456789", "Sunakshi", 50000);
            //account.Display();
            //account.SetBalance(70000);
            //Console.WriteLine("\nAfter Deposit");
            //account.Display();

            Manager manager = new Manager(201, "IT", 85000);
            manager.Display();
            manager.SetSalary(95000);
            Console.WriteLine("\nAfter Salary Update");
            manager.Display();

            Console.ReadLine();
        }
    }
}
