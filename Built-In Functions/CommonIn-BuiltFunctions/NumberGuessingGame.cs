using System;

namespace CommonIn_BuiltFunctions
{
    class NumberGuessingGame
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Think of a number between 1 and 100.");
            Console.WriteLine("Press Enter when you are ready...");
            Console.ReadLine();
            int low = 1;
            int high = 100;
            while (true)
            {
                int guess = GenerateGuess(low, high);

                Console.WriteLine($"Computer Guess: {guess}");
                Console.Write("Enter H (High), L (Low), C (Correct): ");
                char feedback = Convert.ToChar(Console.ReadLine().ToUpper());

                if (feedback == 'C')
                {
                    Console.WriteLine("Computer guessed the correct number!");
                    break;
                }
                else if (feedback == 'H')
                {
                    high = guess - 1;
                }
                else if (feedback == 'L')
                {
                    low = guess + 1;
                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                }
            }
        }

        static int GenerateGuess(int low, int high)
        {
            Random random = new Random();
            return random.Next(low, high + 1);
        }
    }
}