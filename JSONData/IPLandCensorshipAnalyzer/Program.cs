using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

class Program
{
    static void Main()
    {
        // ---------------- JSON INPUT ----------------

        string json = File.ReadAllText("ipl.json");
        List<IPLMatch> matches = JsonSerializer.Deserialize<List<IPLMatch>>(json) ?? new List<IPLMatch>();

        // ---------------- CENSOR JSON DATA ----------------

        foreach (IPLMatch match in matches)
        {
            string oldTeam1 = match.team1;
            string oldTeam2 = match.team2;

            string newTeam1 = CensorTeamName(oldTeam1);
            string newTeam2 = CensorTeamName(oldTeam2);

            match.team1 = newTeam1;
            match.team2 = newTeam2;

            // Censor winner
            match.winner = CensorTeamName(match.winner);

            // Censor score keys
            Dictionary<string, int> newScore = new Dictionary<string, int>();

            foreach (var score in match.score)
            {
                string censoredTeam = CensorTeamName(score.Key);

                newScore[censoredTeam] = score.Value;
            }

            match.score = newScore;

            // Redact player
            match.player_of_match = "REDACTED";
        }


        // ---------------- WRITE CENSORED JSON ----------------

        string censoredJson = JsonSerializer.Serialize(
            matches,
            new JsonSerializerOptions
            {
                WriteIndented = true
            });

        File.WriteAllText("censored_ipl.json", censoredJson);

        Console.WriteLine("Censored JSON file created.");


        // ---------------- CSV INPUT ----------------

        string[] lines = File.ReadAllLines("ipl.csv");

        List<string> outputLines = new List<string>();

        // Header
        outputLines.Add(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            if (string.IsNullOrWhiteSpace(lines[i]))
                continue;
            string[] data = lines[i].Split(',');

            if (data.Length < 7)
            {
                Console.WriteLine($"Invalid CSV row: {lines[i]}");
                continue;
            }

            string team1 = CensorTeamName(data[1]);
            string team2 = CensorTeamName(data[2]);
            string winner = CensorTeamName(data[5]);

            string output = $"{data[0]},{team1},{team2},{data[3]},{data[4]},{winner},REDACTED";

            outputLines.Add(output);
        }

        File.WriteAllLines("censored_ipl.csv", outputLines);

        Console.WriteLine("Censored CSV file created.");

        Console.ReadLine();
    }


    // ---------------- TEAM CENSORING METHOD ----------------

    static string CensorTeamName(string teamName)
    {
        string[] words = teamName.Split(' ');

        if (words.Length == 2)
        {
            return words[0] + " ***";
        }

        if (words.Length == 3)
        {
            return words[0] + " *** " + words[2];
        }

        return "***";
    }
}

