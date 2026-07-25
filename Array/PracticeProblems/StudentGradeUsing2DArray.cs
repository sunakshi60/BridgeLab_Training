using System;

namespace PracticeProblems
{
	internal static class StudentGradeUsing2DArray
	{
		public static void Run()
		{
			Console.Write("Enter number of students: ");
			int students = int.Parse(Console.ReadLine());

			int[,] marks = new int[students, 3];

			double[] percentage = new double[students];
			string[] grade = new string[students];

			for (int i = 0; i < students; i++)
			{
				Console.WriteLine($"\nStudent {i + 1}");

				Console.Write("Physics: ");
				marks[i, 0] = int.Parse(Console.ReadLine());

				Console.Write("Chemistry: ");
				marks[i, 1] = int.Parse(Console.ReadLine());

				Console.Write("Maths: ");
				marks[i, 2] = int.Parse(Console.ReadLine());

				if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0)
				{
					Console.WriteLine("Marks cannot be negative. Please enter all marks again.");
					i--;
					continue;
				}

				percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

				if (percentage[i] >= 90)
					grade[i] = "A";
				else if (percentage[i] >= 75)
					grade[i] = "B";
				else if (percentage[i] >= 50)
					grade[i] = "C";
				else if (percentage[i] >= 35)
					grade[i] = "D";
				else
					grade[i] = "F";
			}

			Console.WriteLine("\nPhy\tChem\tMath\tPercentage\tGrade");

			for (int i = 0; i < students; i++)
			{
				Console.WriteLine($"{marks[i, 0]}\t{marks[i, 1]}\t{marks[i, 2]}\t{percentage[i]:F2}\t\t{grade[i]}");
			}
		}
	}
}