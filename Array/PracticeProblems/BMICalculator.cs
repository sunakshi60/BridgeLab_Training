using System;

namespace PracticeProblems
{
	internal class BMICalculator
	{
		public static void Run()
		{
			Console.Write("Enter number of persons: ");
			int persons = int.Parse(Console.ReadLine());

			double[] weights = new double[persons];
			double[] heights = new double[persons];
			double[] bmi = new double[persons];
			string[] status = new string[persons];

			// Input height and weight
			for (int i = 0; i < persons; i++)
			{
				Console.WriteLine($"\nPerson {i + 1}");

				Console.Write("Enter Weight (kg): ");
				weights[i] = double.Parse(Console.ReadLine());

				Console.Write("Enter Height (m): ");
				heights[i] = double.Parse(Console.ReadLine());

				bmi[i] = weights[i] / (heights[i] * heights[i]);

				if (bmi[i] < 18.5)
				{
					status[i] = "Underweight";
				}
				else if (bmi[i] < 25)
				{
					status[i] = "Normal Weight";
				}
				else if (bmi[i] < 30)
				{
					status[i] = "Overweight";
				}
				else
				{
					status[i] = "Obese";
				}
			}

			Console.WriteLine("Height(m)\tWeight(kg)\tBMI\t\tStatus");

			for (int i = 0; i < persons; i++)
			{
				Console.WriteLine($"{heights[i]}\t\t{weights[i]}\t\t{bmi[i]:F2}\t\t{status[i]}");
			}
		}
	}
}