using System;
using System.Collections.Generic;

public class CustomSort
{
    public static void Solve()
    {
        List<string> names = new()
        {
            "Aarav",
            "Priyanka",
            "Om",
            "Siddharth",
            "Dia"
        };
        names.Sort((name1, name2) => name1.Length.CompareTo(name2.Length));
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}