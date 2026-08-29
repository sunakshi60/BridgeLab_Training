using System;
using System.IO;

public class Employee
{
	public static void Run()
	{
		string filepath = "Employees.csv";
		string[] employees =
		{
			"ID,Name,Department,Salary",
			"101,Sunakshi,IT,55000",
			"102,Anu,HR,48000",
			"103,Preeti,Finance,60000",
			"104,Nancy,Marketing,52000",
			"105,Riya,IT,65000"
		};
		File.WriteAllLines(filepath, employees);
		Console.WriteLine("Employee data written successfully to CSV file.");
	}
}