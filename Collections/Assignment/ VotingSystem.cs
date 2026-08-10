using System;
using System.Collections.Generic;

public class VotingSystem
{
    private Dictionary<string, int> votes =new Dictionary<string, int>();

    private List<string> voteOrder =new List<string>();

    public void CastVote(string candidate)
    {
        if (votes.ContainsKey(candidate))
        {
            votes[candidate]++;
        }
        else
        {
            votes[candidate] = 1;
            voteOrder.Add(candidate);
        }
    }

    public void DisplayResults()
    {
        Console.WriteLine("\nVoting Results:");
        foreach (var vote in votes)
        {
            Console.WriteLine(
                $"{vote.Key}: {vote.Value}");
        }
    }

    public void DisplaySortedResults()
    {
        SortedDictionary<string, int> sortedVotes = new SortedDictionary<string, int>(votes);
        Console.WriteLine("\nSorted Voting Results:");
        foreach (var vote in sortedVotes)
        {
            Console.WriteLine(
                $"{vote.Key}: {vote.Value}");
        }
    }

    public void DisplayVoteOrder()
    {
        Console.WriteLine("\nVote Order:");
        foreach (string candidate in voteOrder)
        {
            Console.WriteLine(candidate);
        }
    }
}