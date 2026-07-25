using System;

namespace ControlFlowPracticeProblems
{
	internal static class RocketCountdownWhile
	{
		public static void Run()
		{
			Console.Write("Enter countdown number: ");
			int counter = int.Parse(Console.ReadLine());

			while (counter >= 1)
			{
				Console.WriteLine(counter);
				counter--;
			}

			Console.WriteLine("Rocket Launched!");
		}
	}
}