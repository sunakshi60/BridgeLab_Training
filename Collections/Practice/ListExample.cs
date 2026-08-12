using System;
using System.Collections.Generic;


public class ListExample
{
    public void Run()
    {
        Console.WriteLine("\n===== LIST =====");

        IList<string> students = new List<string>();

        students.Add("Sakshi");
        students.Add("Rahul");
        students.Add("Ananya");

        Console.WriteLine("After Add:");
        Display(students);

        students.Insert(1, "Priya");

        Console.WriteLine("\nAfter Insert:");
        Display(students);

        Console.WriteLine("\nElement at index 2: " + students[2]);

        Console.WriteLine("Contains Rahul: " + students.Contains("Rahul"));

        Console.WriteLine("Index of Ananya: " + students.IndexOf("Ananya"));

        students.Remove("Rahul");

        Console.WriteLine("\nAfter Remove:");
        Display(students);

        students.RemoveAt(0);

        Console.WriteLine("\nAfter RemoveAt:");
        Display(students);

        Console.WriteLine("\nCount: " + students.Count);

        students.Clear();

        Console.WriteLine("After Clear, Count: " + students.Count);
    }

    private void Display(IList<string> list)
    {
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}