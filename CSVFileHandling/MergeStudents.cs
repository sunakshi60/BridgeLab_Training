using System;
using System.Collections.Generic;
using System.IO;

public class MergeStudents
{
    public static void Run()
    {
        string file1 = "students1.csv";
        string file2 = "students2.csv";
        string outputFile = "merged_students.csv";
        string[] studentDetails = File.ReadAllLines(file1);
        Dictionary<int, string[]> marksData = new Dictionary<int, string[]>();
        string[] marksLines = File.ReadAllLines(file2);
        for (int i = 1; i < marksLines.Length; i++)
        {
            string[] data = marksLines[i].Split(',');
            int id = int.Parse(data[0]);
            marksData[id] = data;
        }
        List<string> mergedRecords = new List<string>();
        mergedRecords.Add("ID,Name,Age,Marks,Grade");
        for (int i = 1; i < studentDetails.Length; i++)
        {
            string[] studentData = studentDetails[i].Split(',');
            int id = int.Parse(studentData[0]);
            if (marksData.ContainsKey(id))
            {
                string[] marks = marksData[id];
                string mergedRow = $"{studentData[0]},{studentData[1]},{studentData[2]},{marks[1]},{marks[2]}";
                mergedRecords.Add(mergedRow);
            }
        }
        File.WriteAllLines(outputFile, mergedRecords);
        Console.WriteLine("CSV files merged successfully.");
        Console.WriteLine($"Output file: {outputFile}");
    }
}