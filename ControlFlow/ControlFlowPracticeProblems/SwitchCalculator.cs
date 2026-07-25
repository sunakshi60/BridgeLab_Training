using System;

namespace ControlFlowPracticeProblems
{
    internal static class SwitchCalculator
    {
        public static void Run()
        {
            Console.Write("Enter First Number: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Enter Operator (+, -, *, /): ");
            string op = Console.ReadLine();

            Console.Write("Enter Second Number: ");
            double second = double.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Console.WriteLine($"Result = {first + second}");
                    break;

                case "-":
                    Console.WriteLine($"Result = {first - second}");
                    break;

                case "*":
                    Console.WriteLine($"Result = {first * second}");
                    break;

                case "/":
                    if (second != 0)
                        Console.WriteLine($"Result = {first / second}");
                    else
                        Console.WriteLine("Division by zero is not allowed.");
                    break;

                default:
                    Console.WriteLine("Invalid Operator.");
                    break;
            }
        }
    }
}