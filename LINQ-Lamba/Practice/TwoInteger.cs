using System;
using System.Collections.Generic;

public class TwoInteger
{
   public static void Solve()
    {
        Func<string> status = () => "Ready";
        Console.WriteLine(status());

        Func<int, int, int> larger = (a, b) => a > b ? a : b;
        Console.WriteLine(larger(10, 25));
    }
}