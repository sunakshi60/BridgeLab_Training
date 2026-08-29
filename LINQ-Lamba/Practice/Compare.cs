using System;
using System.Collections.Generic;

public class Compare
{
    delegate bool Comparer(string first, string second);
    
    public static void Solve()
    {
        Comparer compare = (first, second) => first.Length < second.Length;
        bool result = compare("Hii", "Hello");
        Console.WriteLine(result);
    }

}