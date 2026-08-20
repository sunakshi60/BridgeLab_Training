using System;

namespace PracticeProblems
{
    class Program
    {
        static void Main()
        {
            //FileHandler file = new FileHandler();
            //file.ReadFile();


            //DivisionHandler division = new DivisionHandler();
            //division.DivideNumbers();


            //Console.Write("Enter your age: ");
            //try
            //{
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    AgeValidator validator = new AgeValidator();
            //    validator.ValidateAge(age);
            //}
            //catch (InvalidAgeException)
            //{
            //    Console.WriteLine("Age must be 18 or above");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Please enter a valid age.");
            //}

            //ArrayHandler handler = new ArrayHandler();
            //int[] numbers = { 10, 20, 30, 40, 50 };
            //Console.Write("Enter index: ");
            //int index = Convert.ToInt32(Console.ReadLine());
            //handler.GetValue(numbers, index);


            //FileReader fileReader = new FileReader();
            //fileReader.ReadFirstLine();



            //InterestCalculator calculator = new InterestCalculator();
            //try
            //{
            //    Console.Write("Enter amount: ");
            //    double amount = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Enter rate: ");
            //    double rate = Convert.ToDouble(Console.ReadLine());
            //    Console.Write("Enter years: ");
            //    int years = Convert.ToInt32(Console.ReadLine());
            //    double interest = calculator.CalculateInterest(amount, rate, years);
            //    Console.WriteLine("Calculated Interest: " + interest);
            //}
            //catch (ArgumentException)
            //{
            //    Console.WriteLine("Invalid input: Amount and rate must be positive");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Please enter valid numeric values.");
            //}


            //DivisionFinallyHandler handler = new DivisionFinallyHandler();
            //handler.DivideNumbers();


            //ExceptionPropagation handler = new ExceptionPropagation();
            //try
            //{
            //    handler.Method2();
            //}
            //catch (ArithmeticException)
            //{
            //    Console.WriteLine("Handled exception in Main");
            //}


            //int[] numbers = { 10, 20, 30, 40, 50 };
            //Console.Write("Enter index: ");
            //int index = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter divisor: ");
            //int divisor = Convert.ToInt32(Console.ReadLine());
            //NestedTryHandler handler = new NestedTryHandler();
            //handler.PerformOperation(numbers, index, divisor);


            BankAccount account = new BankAccount(10000);
            Console.Write("Enter withdrawal amount: ");
            try
            {
                double amount = Convert.ToDouble(Console.ReadLine());

                account.Withdraw(amount);
            }
            catch (InsufficientFundsException)
            {
                Console.WriteLine("Insufficient balance!");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid amount!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a valid amount.");
            }

            Console.ReadLine();
        }
    }
}