using System;
using System.Collections.Generic;
using System.Linq;

public class SelectPractice
{
    public static void Solve()
    {
        List<string> names = new List<string> { "Sunakshi", "Rahul", "Preet" };
        var upperCaseNames = names.Select(name => name.ToUpper());
        Console.WriteLine("Uppercase Names:");
        foreach (var name in upperCaseNames)
        {
            Console.WriteLine(name);
        }

        var nameLengths = names.Select(name => name.Length);
        Console.WriteLine("\nName Lengths:");
        foreach (var length in nameLengths)
        {
            Console.WriteLine(length);
        }

        var studentNames = names.Select(name => "Student: " + name);
        Console.WriteLine("\nStudent Names:");
        foreach (var name in studentNames)
        {
            Console.WriteLine(name);
        }
    }
}