using System;
using System.IO;

public class Student
{
	public static void Run() {
		string filepath = "students.csv";
		string[] lines = File.ReadAllLines(filepath);
		for (int i = 1; i < lines.Length; i++) {
			string[] data = lines[i].Split(',');
			int id = int.Parse(data[0]);
			string name = data[1];
			int age = int.Parse(data[2]);
			double marks = double.Parse(data[3]);

			Console.WriteLine($"ID     : {id}");
			Console.WriteLine($"Name   : {name}");
			Console.WriteLine($"Age    : {age}");
			Console.WriteLine($"Marks  : {marks}");
		}
 	}
}
