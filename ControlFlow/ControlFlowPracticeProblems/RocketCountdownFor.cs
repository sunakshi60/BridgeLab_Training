using System;

namespace ControlFlowPracticeProblems
{
    internal static class RocketCountdownFor
    {
        public static void Run()
        {
            Console.Write("Enter countdown number: ");
            int counter = int.Parse(Console.ReadLine());

            for (int i = counter; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Rocket Launched!");
        }
    }
}