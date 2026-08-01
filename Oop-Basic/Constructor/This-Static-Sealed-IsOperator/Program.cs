using System;

namespace This_Static_Sealed_IsOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BankAccount account1 = new BankAccount(1001, "Preet");
            //BankAccount account2 = new BankAccount(1002, "Anu");
            //if (account1 is BankAccount)
            //{
            //    Console.WriteLine("account1 is a BankAccount object.");
            //    account1.DisplayDetails();
            //}
            //if (account2 is BankAccount)
            //{
            //    Console.WriteLine("\naccount2 is a BankAccount object.");
            //    account2.DisplayDetails();
            //}
            //BankAccount.GetTotalAccounts();


            //Book book1 = new Book("C# Programming", "James", "ISBN101");
            //Book book2 = new Book("Data Structures", "Robert", "ISBN102");
            //Book.DisplayLibraryName();
            //if (book1 is Book)
            //{
            //    Console.WriteLine("\nbook1 is a Book object.");
            //    book1.DisplayBookDetails();
            //}
            //if (book2 is Book)
            //{
            //    Console.WriteLine("\nbook2 is a Book object.");
            //    book2.DisplayBookDetails();
            //}


            //Employee emp1 = new Employee(101, "Preet", "Software Engineer");
            //Employee emp2 = new Employee(102, "Rahul", "QA Engineer");
            //if (emp1 is Employee)
            //{
            //    Console.WriteLine("emp1 is an Employee object.");
            //    emp1.DisplayEmployeeDetails();
            //}
            //if (emp2 is Employee)
            //{
            //    Console.WriteLine("\nemp2 is an Employee object.");
            //    emp2.DisplayEmployeeDetails();
            //}
            //Employee.DisplayTotalEmployees();


            //Product product1 = new Product(101, "Laptop", 60000, 1);
            //Product product2 = new Product(102, "Mouse", 800, 2);
            //Console.WriteLine("Before Updating Discount");
            //if (product1 is Product)
            //{
            //    Console.WriteLine("\nproduct1 is a Product object.");
            //    product1.DisplayProductDetails();
            //}
            //if (product2 is Product)
            //{
            //    Console.WriteLine("\nproduct2 is a Product object.");
            //    product2.DisplayProductDetails();
            //}
            //Product.UpdateDiscount(20);
            //Console.WriteLine("\nAfter Updating Discount");
            //product1.DisplayProductDetails();
            //product2.DisplayProductDetails();


            //Student student1 = new Student(101, "Preet", "A");
            //Student student2 = new Student(102, "Rahul", "B+");
            //if (student1 is Student)
            //{
            //    Console.WriteLine("student1 is a Student object.");
            //    student1.DisplayStudentDetails();

            //    student1.UpdateGrade("A+");
            //    Console.WriteLine("\nAfter Grade Update");
            //    student1.DisplayStudentDetails();
            //}
            //if (student2 is Student)
            //{
            //    Console.WriteLine("\nstudent2 is a Student object.");
            //    student2.DisplayStudentDetails();
            //}
            //Student.DisplayTotalStudents();


            //Vehicle vehicle1 = new Vehicle("HP01AB1234", "Preet", "Car");
            //Vehicle vehicle2 = new Vehicle("PB10CD5678", "Rahul", "Bike");
            //Console.WriteLine("Before Updating Registration Fee");
            //if (vehicle1 is Vehicle)
            //{
            //    Console.WriteLine("\nvehicle1 is a Vehicle object.");
            //    vehicle1.DisplayVehicleDetails();
            //}
            //if (vehicle2 is Vehicle)
            //{
            //    Console.WriteLine("\nvehicle2 is a Vehicle object.");
            //    vehicle2.DisplayVehicleDetails();
            //}
            //Vehicle.UpdateRegistrationFee(3500);
            //Console.WriteLine("\nAfter Updating Registration Fee");
            //vehicle1.DisplayVehicleDetails();
            //vehicle2.DisplayVehicleDetails();


            Patient patient1 = new Patient(101, "Preet", 21, "Fever");
            Patient patient2 = new Patient(102, "Rahul", 25, "Fracture");
            if (patient1 is Patient)
            {
                Console.WriteLine("patient1 is a Patient object.");
                patient1.DisplayPatientDetails();
            }
            if (patient2 is Patient)
            {
                Console.WriteLine("\npatient2 is a Patient object.");
                patient2.DisplayPatientDetails();
            }
            Patient.GetTotalPatients();

            Console.ReadLine();
        }
    }
}
