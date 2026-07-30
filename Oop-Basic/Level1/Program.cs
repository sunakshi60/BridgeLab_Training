using System;

namespace Level1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee("Alice", 173, 50000);
            //emp.DisplayDetails();

            //Circle c1 = new Circle(43);
            //c1.Display();

            Book b1 = new Book("C# Programming","John Smith",799);
            b1.DisplayBookDetails();


            Console.ReadLine();
        }
    }
}
