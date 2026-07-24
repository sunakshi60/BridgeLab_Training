using System;

namespace PracticeQues
{
	internal static class AveragePCMMarks
	{
		public static void Run()
		{
			Console.Write("Enter Maths Marks: ");
			double maths = double.Parse(Console.ReadLine());

			Console.Write("Enter Physics Marks: ");
			double physics = double.Parse(Console.ReadLine());

			Console.Write("Enter Chemistry Marks: ");
			double chemistry = double.Parse(Console.ReadLine());

			double average = (maths + physics + chemistry) / 3;

			Console.WriteLine($"Average mark in PCM is = {average}");
			
		}
	}
}