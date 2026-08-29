using System;
using System.Collections.Generic;
using System.IO;

public class DetectDuplicates
{
    public static void Run()
    {
        string filepath = "Students.csv";
        string[] lines = File.ReadAllLines(filepath);
        HashSet<int> ids = new HashSet<int>();
        List<string> duplicateRecords = new List<string>();
        for (int i = 1; i < lines.Length; i++)
        {
            string[] data = lines[i].Split(',');
            int id = int.Parse(data[0]);
            if (ids.Contains(id))
            {
                duplicateRecords.Add(lines[i]);
            }
            else
            {
                ids.Add(id);
            }
        }
        Console.WriteLine("Duplicate Records:");
        if (duplicateRecords.Count == 0)
        {
            Console.WriteLine("No duplicate records found.");
        }
        else
        {
            foreach (string record in duplicateRecords)
            {
                Console.WriteLine(record);
            }
        }
    }
}