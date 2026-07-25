using System;

namespace ControlFlowPracticeProblems
{
	internal static class BMICalculator
	{
		public static void Run()
		{
			Console.Write("Enter Weight (kg): ");
			double weight = double.Parse(Console.ReadLine());

			Console.Write("Enter Height (cm): ");
			double height = double.Parse(Console.ReadLine());

			double heightInMeter = height / 100;

			double bmi = weight / (heightInMeter * heightInMeter);

			Console.WriteLine($"BMI = {bmi:F2}");

			if (bmi < 18.5)
				Console.WriteLine("Underweight");
			else if (bmi < 25)
				Console.WriteLine("Normal Weight");
			else if (bmi < 30)
				Console.WriteLine("Overweight");
			else
				Console.WriteLine("Obese");
		}
	}
}