using System;

namespace CommonIn_BuiltFunctions
{
    class PrimeNumberChecker
    {
        public static void Run()
        {
            int number = GetNumber();
            if (IsPrime(number))
            {
                Console.WriteLine(number + " is a Prime Number.");
            }
            else
            {
                Console.WriteLine(number + " is not a Prime Number.");
            }
        }

        static int GetNumber()
        {
            Console.Write("Enter a Number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}