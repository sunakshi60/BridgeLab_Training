using System;

namespace LinkedListQues
{
    public class Employee
    {
        public int Id;
        public string Name;
        public string Department;
        public double Salary;

        public Employee(int id, string name, string department, double salary)
        {
            Id = id;
            Name = name;
            Department = department;
            Salary = salary;
        }

        public void Display()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Department: {Department}, Salary: {Salary}");
        }
    }


    public class EmployeeNode
    {
        public Employee Data;
        public EmployeeNode Next;

        public EmployeeNode(Employee data)
        {
            Data = data;
            Next = null;
        }
    }


    public class EmployeeLinkedList
    {
        private EmployeeNode head;

        public EmployeeLinkedList()
        {
            head = null;
        }

        public void AddAtBeginning(Employee employee)
        {
            EmployeeNode newNode = new EmployeeNode(employee);

            newNode.Next = head;
            head = newNode;

            Console.WriteLine(
                "Employee added at beginning successfully."
            );
        }

        public void AddAtEnd(Employee employee)
        {
            EmployeeNode newNode = new EmployeeNode(employee);

            if (head == null)
            {
                head = newNode;

                Console.WriteLine("Employee added at the end.");

                return;
            }

            EmployeeNode curr = head;

            while (curr.Next != null)
            {
                curr = curr.Next;
            }

            curr.Next = newNode;

            Console.WriteLine(
                "Employee added at the end."
            );
        }


        public void AddAtPosition(Employee employee, int position)
        {
            if (position < 1)
            {
                Console.WriteLine("Invalid position.");
                return;
            }

            if (position == 1)
            {
                AddAtBeginning(employee);
                return;
            }

            if (head == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }

            EmployeeNode newNode = new EmployeeNode(employee);

            EmployeeNode curr = head;

            for (int i = 1; i < position - 1 && curr != null; i++)
            {
                curr = curr.Next;
            }

            if (curr == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }

            newNode.Next = curr.Next;
            curr.Next = newNode;

            Console.WriteLine($"Employee added at position {position}.");
        }


        public void DeleteById(int id)
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            if (head.Data.Id == id)
            {
                head = head.Next;

                Console.WriteLine("Employee deleted successfully.");

                return;
            }

            EmployeeNode curr = head;

            while (curr.Next != null)
            {
                if (curr.Next.Data.Id == id)
                {
                    curr.Next = curr.Next.Next;

                    Console.WriteLine("Employee deleted successfully.");

                    return;
                }

                curr = curr.Next;
            }

            Console.WriteLine("Employee not found.");
        }

        public Employee SearchById(int id)
        {
            EmployeeNode current = head;

            while (current != null)
            {
                if (current.Data.Id == id)
                {
                    return current.Data;
                }

                current = current.Next;
            }

            return null;
        }

        public Employee SearchByName(string name)
        {
            EmployeeNode curr = head;

            while (curr != null)
            {
                if (curr.Data.Name.Equals(
                    name,
                    StringComparison.OrdinalIgnoreCase))
                {
                    return curr.Data;
                }

                curr = curr.Next;
            }

            return null;
        }


        public void DisplayAll()
        {
            if (head == null)
            {
                Console.WriteLine("No data found.");
                return;
            }

            EmployeeNode curr = head;

            Console.WriteLine("\n------------ Employee Details ------------");

            while (curr != null)
            {
                curr.Data.Display();

                curr = curr.Next;
            }
        }
    }
}