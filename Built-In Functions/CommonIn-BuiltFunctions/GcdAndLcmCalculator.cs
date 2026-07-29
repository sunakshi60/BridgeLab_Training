using System;

namespace CommonIn_BuiltFunctions
{
    class GcdAndLcmCalculator
    {
        public static void Run()
        {
            int num1 = GetNumber("Enter First Number: ");
            int num2 = GetNumber("Enter Second Number: ");
            int gcd = FindGCD(num1, num2);
            int lcm = FindLCM(num1, num2);
            DisplayResult(gcd, lcm);
        }

        static int GetNumber(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int remainder = a % b;
                a = b;
                b = remainder;
            }
            return a;
        }

        static int FindLCM(int a, int b)
        {
            return (a * b) / FindGCD(a, b);
        }

        static void DisplayResult(int gcd, int lcm)
        {
            Console.WriteLine("GCD = " + gcd);
            Console.WriteLine("LCM = " + lcm);
        }
    }
}