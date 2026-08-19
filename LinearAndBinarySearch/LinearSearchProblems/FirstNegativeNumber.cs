using System;

namespace LinearSearchProblems
{
	public class FirstNegativeNumber
	{
		public static void Search()
		{
			int[] numbers = { 10, 25, 8, 15, -7, 20, -12, 5 };

			for (int i = 0; i < numbers.Length; i++)
			{
				if (numbers[i] < 0)
				{
					Console.WriteLine($"First negative number: {numbers[i]}");
					Console.WriteLine($"Found at index: {i}");
					return;
				}
			}

			Console.WriteLine("No negative number found.");
		}
	}
}