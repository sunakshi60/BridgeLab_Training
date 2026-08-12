using System;
using System.Collections.Generic;

public class MapExample
{
    public void Run()
    {
        Console.WriteLine("\n===== MAP / DICTIONARY =====");

        IDictionary<int, string> students = new Dictionary<int, string>();

        students.Add(101, "Sakshi");
        students.Add(102, "Rahul");
        students.Add(103, "Ananya");

        Console.WriteLine("Dictionary:");
        Display(students);

        Console.WriteLine("\nStudent with ID 102: " + students[102]);

        Console.WriteLine("Contains Key 101: " + students.ContainsKey(101));

        Console.WriteLine("Contains Value Rahul: " + students.Values.Contains("Rahul"));

        students.Remove(103);

        Console.WriteLine("\nAfter Remove:");
        Display(students);

        if (students.TryGetValue(101, out string? student))
        {
            Console.WriteLine("\nFound Student: " + student);
        }

        IDictionary<int, string> sortedStudents =
            new SortedDictionary<int, string>
            {
                { 103, "Ananya" },
                { 101, "Sakshi" },
                { 102, "Rahul" }
            };

        Console.WriteLine("\nSortedDictionary:");
        Display(sortedStudents);
    }

    private void Display(IDictionary<int, string> map)
    {
        foreach (KeyValuePair<int, string> pair in map)
        {
            Console.WriteLine("Key: " + pair.Key + ", Value: " + pair.Value);
        }
    }
}