using System;
using System.Collections.Generic;

public class Product
{
    public static void Solve()
    {
        Func<int, int, int > multiply = (a,b) => a*b;
        Console.WriteLine(multiply(4,5));
    }
}