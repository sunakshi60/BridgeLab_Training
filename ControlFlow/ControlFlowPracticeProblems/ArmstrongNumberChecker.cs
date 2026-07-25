using System;

namespace ControlFlowPracticeProblems
{
	internal static class ArmstrongNumberChecker
	{
		public static void Run()
		{
			Console.Write("Enter a Number: ");
			int number = int.Parse(Console.ReadLine());

			int originalNumber = number;
			int sum = 0;

			while (originalNumber != 0)
			{
				int digit = originalNumber % 10;
				sum += digit * digit * digit;
				originalNumber /= 10;
			}

			if (sum == number)
			{
				Console.WriteLine($"{number} is an Armstrong Number.");
			}
			else
			{
				Console.WriteLine($"{number} is not an Armstrong Number.");
			}
		}
	}
}