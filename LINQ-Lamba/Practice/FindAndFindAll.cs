using System;
using System.Collections.Generic;

public class Find
{
    public static void Solve()
    {
        List<string> names = new List<string>
        {
            "Rahul","Anu","Aman","Priya","Aditi"
        };
         string firstName = names.Find(name => name.StartsWith("A"));
        Console.WriteLine("First name: " + firstName);

        List<string> allNames = names.FindAll(name => name.StartsWith("A"));
        Console.WriteLine("All names:");
        foreach (string name in allNames)
        {
            Console.WriteLine(name);
        }
    }
}