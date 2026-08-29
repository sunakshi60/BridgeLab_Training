using System;
using System.IO;

public class CountCsvRows
{
    public static void Run()
    {
        string filepath = "students.csv";
        string[] lines = File.ReadAllLines(filepath);
        int recordCount = lines.Length > 0 ? lines.Length - 1 : 0; 
        Console.WriteLine($"Number of records: {recordCount}");
    }
}