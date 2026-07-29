using System;

namespace CommonIn_BuiltFunctions
{
    class BasicCalculator
    {
        public static void Run()
        {
            double num1 = GetNumber("Enter First Number: ");
            double num2 = GetNumber("Enter Second Number: ");
            Console.WriteLine("\nChoose an Operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.Write("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Result = " + Add(num1, num2));
                    break;

                case 2:
                    Console.WriteLine("Result = " + Subtract(num1, num2));
                    break;

                case 3:
                    Console.WriteLine("Result = " + Multiply(num1, num2));
                    break;

                case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine("Result = " + Divide(num1, num2));
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not possible.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid Choice!");
                    break;
            }
        }

        static double GetNumber(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            return a / b;
        }
    }
}