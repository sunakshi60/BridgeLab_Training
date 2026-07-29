using System;

namespace CommonIn_BuiltFunctions
{
    class FactorialUsingRecursion
    {
        public static void Run()
        {
            int number = GetNumber();
            long factorial = FindFactorial(number);
            DisplayResult(number, factorial);
        }

        static int GetNumber()
        {
            Console.Write("Enter a Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static long FindFactorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }
            return number * FindFactorial(number - 1);
        }

        static void DisplayResult(int number, long factorial)
        {
            Console.WriteLine("Factorial of " + number + " = " + factorial);
        }
    }
}