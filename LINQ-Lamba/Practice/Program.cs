using System;
using System.Net.Http.Headers;

public class Program
{   
    static void Main(string[] args)
    {
        //LinqPractice.Solve();

        //WherePractice.Solve();

        //SelectPractice.Solve();

        //ModifyString.Solve();

        //ProductFilter.Solve();

        //CustomSort.Solve();

        //Product.Solve();

        //TwoInteger.Solve();

        //Compare.Solve();


        //Action<int, int> printSum = (a, b) => Console.WriteLine(a + b);
        //printSum(10, 20);


        //Func<double, double, double> average = (a, b) => (a + b) / 2;
        //average(10, 20);


        //Predicate<int> isPrime = number =>
        //{
        //    if (number < 2)
        //        return false;

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }

        //    return true;
        //};
        //Console.Write(isPrime(3));


        //Action<string> sendEmail = email =>
        //{
        //    Console.WriteLine($"Sending email to {email}");
        //};
        //sendEmail("sakshi@gmail.com");

        //Func<double, double> calculateTax = income => income * 0.20;
        //Console.Write(calculateTax(2));

        //ParameterAsLambda.Solve();

        //Find.Solve();

        //List<Employee> employees = new List<Employee>
        //{
        //    new Employee("Rahul", "IT"),
        //    new Employee("Aman", "HR"),
        //    new Employee("Anu", "IT"),
        //    new Employee("Priya", "HR"),
        //    new Employee("Karan", "Finance")
        //};

        //employees.Sort((e1, e2) =>
        //{
        //    int departmentResult = e1.Department.CompareTo(e2.Department);

        //    if (departmentResult != 0)  return departmentResult;

        //    return e1.Name.CompareTo(e2.Name);
        //});
        //foreach (Employee emp in employees)
        //{
        //    Console.WriteLine(emp.Name + " - " + emp.Department);
        //}

        FilterEven.Solve();


        Console.ReadLine();
    }
}