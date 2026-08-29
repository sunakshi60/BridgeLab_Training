using System;
using System.IO;

public class FilterStudents
{
    public static void Run()
    {
        string filepath = "students.csv";
        string[] lines = File.ReadAllLines(filepath);
        Console.WriteLine("Students who scored more than 80:");
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            int id = int.Parse(data[0]);
            string name = data[1];
            int age = int.Parse(data[2]);
            double marks = double.Parse(data[3]);
            if (marks > 80)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine($"ID     : {id}");
                Console.WriteLine($"Name   : {name}");
                Console.WriteLine($"Age    : {age}");
                Console.WriteLine($"Marks  : {marks}");
            }
        }
    }
}