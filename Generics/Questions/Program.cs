using System;

namespace Questions
{
    class Program
    {
        public static void Main()
        {
            //FlightSchedule<Flight> schedule = new FlightSchedule<Flight>();
            //schedule.AddFlight(
            //new Flight(
            //    "AI101",
            //    "Air India",
            //    "Delhi",
            //    "Mumbai",
            //     new DateTime(2026, 8, 20, 10, 30, 0),
            //     new DateTime(2026, 8, 20, 12, 45, 0)
            //     )
            //);
            //schedule.AddFlight(
            //new Flight(
            //    "6E202",
            //    "IndiGo",
            //    "Delhi",
            //    "Bangalore",
            //    new DateTime(2026, 8, 20, 14, 00, 0),
            //    new DateTime(2026, 8, 20, 16, 45, 0)
            //    )
            //);
            //schedule.AddFlight(
            //new Flight(
            //    "UK303",
            //    "Vistara",
            //    "Mumbai",
            //    "Bangalore",
            //    new DateTime(2026, 8, 20, 18, 00, 0),
            //    new DateTime(2026, 8, 20, 20, 00, 0)
            //    )
            //);
            //Console.WriteLine("----- ALL FLIGHTS -----");
            //schedule.DisplayFlights();
            //Console.WriteLine("\n----- SEARCH FLIGHT -----");
            //Flight searchedFlight = schedule.SearchFlight("6E202");
            //if (searchedFlight != null)
            //{
            //    Console.WriteLine("Flight Found:");
            //    Console.WriteLine(searchedFlight);
            //}
            //else
            //{
            //    Console.WriteLine("Flight not found.");
            //}
            //Console.WriteLine("\n----- FLIGHTS TO BANGALORE -----");
            //List<Flight> BangaloreFlights = schedule.FindByDestination("Bangalore");
            //foreach (Flight flight in BangaloreFlights)
            //{
            //    Console.WriteLine(flight);
            //}
            //Console.WriteLine("\n----- REMOVE FLIGHT -----");
            //bool removed = schedule.RemoveFlight("AI101");
            //if (removed)
            //{
            //    Console.WriteLine("Flight removed successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Flight not found.");
            //}
            //Console.WriteLine("\n----- FLIGHTS AFTER REMOVAL -----");
            //schedule.DisplayFlights();


            //EmployeeRecordSystem system = new EmployeeRecordSystem();
            //system.AddEmployee(new Employee(101, "Rahul", "IT"));
            //system.AddEmployee(new Employee(102, "Priya", "HR"));
            //system.AddEmployee(new Employee(103, "Aman", "Finance"));
            //Console.WriteLine("\n----- ALL EMPLOYEES -----");
            //system.DisplayAllEmployees();
            //Console.WriteLine("\n----- SEARCH EMPLOYEE -----");
            //Employee employee = system.SearchEmployee(102);
            //if (employee != null)
            //{
            //    Console.WriteLine("Employee Found:");
            //    Console.WriteLine(employee);
            //}
            //else
            //{
            //    Console.WriteLine("Employee not found.");
            //}
            //Console.WriteLine("\n----- UPDATE DEPARTMENT -----");
            //bool updated = system.UpdateDepartment(102, "IT");
            //if (updated)
            //{
            //    Console.WriteLine("Department updated successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Employee not found.");
            //}
            //Console.WriteLine("\n----- AFTER UPDATE -----");
            //employee = system.SearchEmployee(102);
            //if (employee != null)
            //{
            //    Console.WriteLine(employee);
            //}
            //Console.WriteLine("\n----- REMOVE EMPLOYEE -----");
            //bool removed = system.RemoveEmployee(101);
            //if (removed)
            //{
            //    Console.WriteLine("Employee removed successfully.");
            //}
            //else
            //{
            //    Console.WriteLine("Employee not found.");
            //}
            //Console.WriteLine("\n----- FINAL EMPLOYEE RECORDS -----");
            //system.DisplayAllEmployees();


            //LinkedListOperations list = new LinkedListOperations();
            //Console.WriteLine("Original LinkedList:");
            //list.Display();
            //Console.Write("Enter value to remove: ");
            //int value = Convert.ToInt32(Console.ReadLine());
            //list.RemoveAllOccurrences(value);
            //Console.WriteLine("LinkedList after removing all occurrences:");
            //list.Display();


            PrinterQueue printerQueue = new PrinterQueue();

            while (true)
            {
                Console.WriteLine("\n===== Printer Queue System =====");
                Console.WriteLine("1. Add Print Job");
                Console.WriteLine("2. Process Next Job");
                Console.WriteLine("3. Display Pending Jobs");
                Console.WriteLine("4. Validate Parentheses");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Job ID: ");
                        int jobId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter Document Name: ");
                        string documentName = Console.ReadLine() ?? "";

                        Console.Write("Enter Number of Pages: ");
                        int pages = Convert.ToInt32(Console.ReadLine());

                        PrintJob job = new PrintJob(
                            jobId,
                            documentName,
                            pages
                        );
                        if (printerQueue.AddJob(job))
                        {
                            Console.WriteLine("Print job added successfully.");
                        }
                        else
                        {
                            Console.WriteLine(
                                "Job cannot be added because parentheses are not balanced."
                            );
                        }
                        break;

                    case 2:
                        printerQueue.ProcessNextJob();
                        break;

                    case 3:
                        printerQueue.DisplayPendingJobs();
                        break;

                    case 4:
                        Console.Write("Enter text/document name: ");
                        string text = Console.ReadLine() ?? "";
                        printerQueue.ValidateDocument(text);
                        break;

                    case 5:
                        Console.WriteLine("Exiting Printer Queue System...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;

                        Console.ReadLine();
                }
            }
        }
    }
}