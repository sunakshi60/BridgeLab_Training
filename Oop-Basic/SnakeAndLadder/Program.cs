using System;
using System.Collections.Generic;

namespace SnakeAndLadder
{
    internal class Program
    {
        static Random random = new Random();

        // Snakes
        static Dictionary<int, int> snakes = new Dictionary<int, int>()
        {
            {99,54},
            {70,55},
            {52,42},
            {25,2},
            {95,72}
        };

        // Ladders
        static Dictionary<int, int> ladders = new Dictionary<int, int>()
        {
            {6,25},
            {11,40},
            {17,69},
            {46,90},
            {60,85}
        };

        static void Main(string[] args)
        {
            Console.WriteLine("---Snake & Ladder Game---");

            int playerCount;

            do
            {
                Console.Write("Enter number of players (2-4): ");
                playerCount = Convert.ToInt32(Console.ReadLine());
            } 
            while (playerCount < 2 || playerCount > 4);

            List<Player> players = new List<Player>();

            for(int i = 1; i <= playerCount; i++)
            {
                Console.Write($"Enter Player {i} Name: ");
                string name = Console.ReadLine();

                players.Add(new Player(name));
            }

            Console.Clear();

            Console.WriteLine("Game Started....\n");

            bool gameOver = false;

            while (!gameOver)
            {
                foreach(Player player in players)
                {
                    Console.WriteLine("----------------------------------");
                    Console.WriteLine($"{player.Name}'s Turn");

                    Console.WriteLine("Press Enter to roll Dice...");
                    Console.ReadLine();

                    int dice = RollDice();
                    Console.WriteLine($"Current Position: {player.Position}");
                    Console.WriteLine($"Dice Rolled: {dice}");

                    int oldPosition = player.Position;

                    if (!MovePlayer(player, dice))
                    {
                        continue;
                    }

                    string message = ApplySnakeOrLadder(player);

                    Console.WriteLine($"Dice : {dice}");
                    Console.WriteLine($"Position : {oldPosition} -> {player.Position}");

                    switch (message)
                    {
                        case "":
                            Console.WriteLine("No Snake/Ladder");
                            break;

                        default:
                            Console.WriteLine(message);
                            break;
                    }

                    Console.WriteLine();

                    if (CheckWin(player))
                    {
                        Console.WriteLine($"{player.Name} Wins the Game!");
                        gameOver = true;
                        break;
                    }
                }
            }
            Console.WriteLine("\nGame Over.");
        }

        static int RollDice()
        {
            return random.Next(1, 7);
        }

        static bool MovePlayer(Player player, int dice)
        {
            if (player.Position + dice > 100)
            {
                Console.WriteLine("Move exceeds 100. Turn Skipped.");
                return false;
            }

            player.Position += dice;
            return true;
        }

        static string ApplySnakeOrLadder(Player player)
        {
            if (ladders.ContainsKey(player.Position))
            {
                int old = player.Position;
                player.Position = ladders[player.Position];

                return $"Ladder! {old} -> {player.Position}";
            }

            else if (snakes.ContainsKey(player.Position))
            {
                int old = player.Position;
                player.Position = snakes[player.Position];

                return $"Snake! {old} -> {player.Position}";
            }
            return "";
        }

        static bool CheckWin(Player player)
        {
            return player.Position == 100;
        }
    }
}
