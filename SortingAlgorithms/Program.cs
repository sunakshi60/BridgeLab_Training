using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter number of students: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] marks = new int[n];
            //Console.WriteLine("Enter student marks:");
            //for (int i = 0; i < n; i++)
            //{
            //    marks[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //BubbleSort.Sort(marks);
            //Console.WriteLine("\nStudent marks in ascending order:");
            //foreach (int mark in marks)
            //{
            //    Console.Write(mark + " ");
            //}



            //Console.Write("Enter number of employees: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] employeeIds = new int[n];
            //Console.WriteLine("Enter employee IDs:");
            //for (int i = 0; i < n; i++)
            //{
            //    employeeIds[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //InsertionSort.Sort(employeeIds);
            //Console.WriteLine("\nEmployee IDs in ascending order:");
            //foreach (int id in employeeIds)
            //{
            //    Console.Write(id + " ");
            //}



            //Console.Write("Enter number of books: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double[] prices = new double[n];
            //Console.WriteLine("Enter book prices:");
            //for (int i = 0; i < n; i++)
            //{
            //    prices[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //MergeSort.Sort(prices);
            //Console.WriteLine("\nBook prices in ascending order:");
            //foreach (double price in prices)
            //{
            //    Console.Write(price + " ");
            //}



            //Console.Write("Enter number of products: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double[] prices = new double[n];
            //Console.WriteLine("Enter product prices:");
            //for (int i = 0; i < n; i++)
            //{
            //    prices[i] = Convert.ToDouble(Console.ReadLine());
            //}
            //QuickSort.Sort(prices);
            //Console.WriteLine("\nProduct prices in ascending order:");
            //foreach (double price in prices)
            //{
            //    Console.Write(price + " ");
            //}



            //Console.Write("Enter number of students: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] scores = new int[n];
            //Console.WriteLine("Enter exam scores:");
            //for (int i = 0; i < n; i++)
            //{
            //    scores[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //SelectionSort.Sort(scores);
            //Console.WriteLine("\nExam scores in ascending order:");
            //foreach (int score in scores)
            //{
            //    Console.Write(score + " ");
            //}



            //Console.Write("Enter number of job applicants: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] salaries = new int[n];
            //Console.WriteLine("Enter expected salary demands:");
            //for (int i = 0; i < n; i++)
            //{
            //    salaries[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //HeapSort.Sort(salaries);
            //Console.WriteLine("\nSalary demands in ascending order:");
            //foreach (int salary in salaries)
            //{
            //    Console.Write(salary + " ");
            //}



            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ages = new int[n];
            Console.WriteLine("Enter student ages (10 to 18):");
            for (int i = 0; i < n; i++)
            {
                ages[i] = Convert.ToInt32(Console.ReadLine());

                if (ages[i] < 10 || ages[i] > 18)
                {
                    Console.WriteLine("Invalid age! Please enter age between 10 and 18.");
                    i--;
                }
            }
            int[] sortedAges = CountingSort.Sort(ages);
            Console.WriteLine("\nStudent ages in ascending order:");
            foreach (int age in sortedAges)
            {
                Console.Write(age + " ");
            }


            Console.ReadLine();
        }
    }
}