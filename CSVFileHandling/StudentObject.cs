using System;
using System.Collections.Generic;
using System.IO;

public class StudentObject
{
	public int Id { get; set; }
	public string Name { get; set; }
	public int Age { get; set; }
	public double Marks { get; set; }

	public static void Run()
	{
		string filepath = "Students.csv";
		string[] lines = File.ReadAllLines(filepath);
		List<StudentObject> students = new List<StudentObject>();
		for (int i = 1; i < lines.Length; i++)
		{
			string[] data = lines[i].Split(',');
			StudentObject student = new StudentObject();
			student.Id = int.Parse(data[0]);
			student.Name = data[1];
			student.Age = int.Parse(data[2]);
			student.Marks = double.Parse(data[3]);
			students.Add(student);
		}
		foreach (StudentObject student in students)
		{
			Console.WriteLine("----------------------------");
			Console.WriteLine($"ID     : {student.Id}");
			Console.WriteLine($"Name   : {student.Name}");
			Console.WriteLine($"Age    : {student.Age}");
			Console.WriteLine($"Marks  : {student.Marks}");
		}
	}
}