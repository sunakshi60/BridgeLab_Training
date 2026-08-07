using NUnit_Testing;
using System;

namespace NUnit_Testing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Calculator calc = new Calculator();
            //Console.Write("Enter first number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Addition: " +calc.Add(num1, num2));
            //Console.WriteLine("Subractation: " +calc.Subtract(num1, num2));
            //Console.WriteLine("Multiplication: " +calc.Multiply(num1, num2));
            //Console.WriteLine("Division: "+calc.Divide(num1, num2));


            //PrimeNumber prime = new PrimeNumber();
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (prime.IsPrime(number))
            //{
            //    Console.WriteLine($"{number} is a Prime Number");
            //}
            //else
            //{
            //    Console.WriteLine($"{number} is not a Prime Number");
            //}


            //StringUtils utils = new StringUtils();
            //string reverse = utils.Reverse("hello");
            //Console.WriteLine("Reverse: " + reverse);
            //bool isPalindrome = utils.IsPalindrome("madam");
            //Console.WriteLine("Is Palindrome: " + isPalindrome);
            //string upper = utils.ToUpperCase("sunakshi");
            //Console.WriteLine("Upper Case: " + upper);


            //ListManager manager = new ListManager();
            //List<int> list = new List<int>();
            //manager.AddElement(list, 10);
            //manager.AddElement(list, 20);
            //manager.AddElement(list, 30);
            //Console.WriteLine("Elements in List:");
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Size : " + manager.GetSize(list));
            //manager.RemoveElement(list, 20);
            //Console.WriteLine("\nAfter Removing 20:");
            //foreach (int item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("Size : " + manager.GetSize(list));


            //ExceptionHandling obj = new ExceptionHandling();
            //try
            //{
            //    Console.WriteLine(obj.Divide(10, 0));
            //}
            //catch (ArithmeticException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //DatabaseConnection db = new DatabaseConnection();
            //db.Connect();
            //Console.WriteLine("Connection Status: " + db.IsConnected);
            //db.Disconnect();
            //Console.WriteLine("Connection Status: " + db.IsConnected);


            //EvenNumber even = new EvenNumber();
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (even.IsEven(number))
            //{
            //    Console.WriteLine("Even Number");
            //}
            //else
            //{
            //    Console.WriteLine("Odd Number");
            //}


            //Performance performance = new Performance();
            //Console.WriteLine("Task Started...");
            //string result = performance.LongRunningTask();
            //Console.WriteLine(result);


            //FileProcessor file = new FileProcessor();
            //string filename = "Sample.txt";
            //string content = "Hello NUnit";
            //file.WriteToFile(filename, content);
            //Console.WriteLine("Content Written Successfully");
            //string result = file.ReadFromFile(filename);
            //Console.WriteLine("Content Read : " + result);


            //BankAccount account = new BankAccount();
            //account.Deposit(5000);
            //Console.WriteLine("Balance after Deposit : " + account.GetBalance());
            //account.Withdraw(2000);
            //Console.WriteLine("Balance after Withdraw : " + account.GetBalance());
            //try
            //{
            //    account.Withdraw(4000);
            //}
            //catch (InvalidOperationException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //PasswordValidator validator = new PasswordValidator();
            //Console.Write("Enter Password: ");
            //string password = Console.ReadLine();
            //if (validator.ValidatePassword(password))
            //{
            //    Console.WriteLine("Valid Password");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Password");
            //}


            //TemperatureConverter converter = new TemperatureConverter();
            //Console.Write("Enter Temperature in Celsius: ");
            //double celsius = Convert.ToDouble(Console.ReadLine());
            //double fahrenheit = converter.CelsiusToFahrenheit(celsius);
            //Console.WriteLine("Fahrenheit : " + fahrenheit);
            //Console.Write("Enter Temperature in Fahrenheit: ");
            //double fahrenheitInput = Convert.ToDouble(Console.ReadLine());
            //double celsiusResult = converter.FahrenheitToCelsius(fahrenheitInput);
            //Console.WriteLine("Celsius : " + celsiusResult);


            //UserRegistration user = new UserRegistration();
            //try
            //{
            //    Console.Write("Enter Username: ");
            //    string username = Console.ReadLine();
            //    Console.Write("Enter Email: ");
            //    string email = Console.ReadLine();
            //    Console.Write("Enter Password: ");
            //    string password = Console.ReadLine();
            //    string result = user.RegisterUser(username, email, password);
            //    Console.WriteLine(result);
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            DateFormatter formatter = new DateFormatter();
            Console.Write("Enter Date (yyyy-MM-dd): ");
            string input = Console.ReadLine();
            try
            {
                string result = formatter.FormatDate(input);
                Console.WriteLine("Formatted Date : " + result);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}