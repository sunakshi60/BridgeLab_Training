using System;
using System.Collections.Generic;
using System.Linq;

public class WherePractice
{
    public static void Solve()
    {
        List<int> num = new List<int> { 10,15,22,35,48,55,67,75,90 };
        var even = num.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Even Numbers:");
        foreach (var n in even)
        {
            Console.Write(" "+n);
        }
        
        var greatNumber = num.Where(n => n > 50);
        Console.WriteLine("\nGreat Numbers:");
        foreach (var n in greatNumber)
        {
            Console.Write(" " + n);
        }

        var between20And80 = num.Where(n => n >= 20 && n <= 80).ToList();
        Console.WriteLine("\nBetween 20 and 80 Numbers:");
        foreach (var n in between20And80)
        {
            Console.Write(" " + n);
        }
    }
}