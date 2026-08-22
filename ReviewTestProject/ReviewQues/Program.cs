using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter a single value: ");
        string input = Console.ReadLine();

        if (Regex.IsMatch(input, "^[a-zA-Z]$"))
        {
            Console.WriteLine("The entered value is a Character.");
        }
        else if (Regex.IsMatch(input, "^[0-9]$"))
        {
            Console.WriteLine("The entered value is an Integer.");
        }
        else if(Regex.IsMatch(input, @"^-?\d+$"))
        {
            Console.WriteLine("The entered value is a Special Symbol.");
        }
        else
        {
            Console.WriteLine("Input is Empty.");
        }

        //Console.Write("Enter a single value: ");
        //char ch = Convert.ToChar(Console.ReadLine());

        //if (char.IsLetter(ch))
        //{
        //    Console.WriteLine("The entered value is a Character.");
        //}
        //else if (char.IsDigit(ch))
        //{
        //    Console.WriteLine("The entered value is an Integer.");
        //}
        //else
        //{
        //    Console.WriteLine("The entered value is a Special Symbol.");
        //}

        Console.ReadKey();
    }
}