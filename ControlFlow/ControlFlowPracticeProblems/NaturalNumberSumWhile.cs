using System;

namespace ControlFlowPracticeProblems
{
	internal static class NaturalNumberSumWhile
	{
		public static void Run()
		{
			Console.Write("Enter a natural number: ");
			int number = int.Parse(Console.ReadLine());

			if (number >= 1)
			{
				int sum = 0;
				int i = 1;

				while (i <= number)
				{
					sum += i;
					i++;
				}

				int formulaSum = number * (number + 1) / 2;

				Console.WriteLine($"Sum using while loop = {sum}");
				Console.WriteLine($"Sum using formula = {formulaSum}");
				Console.WriteLine($"Both results are equal? {sum == formulaSum}");
			}
			else
			{
				Console.WriteLine($"{number} is not a natural number.");
			}
		}
	}
}