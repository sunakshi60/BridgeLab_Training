using System;
using System.Collections.Generic;

public class PairWithGivenSum
{
    public bool FindPair(int[] numbers, int target)
    {
        HashSet<int> visited = new HashSet<int>();
        foreach (int number in numbers)
        {
            int required = target - number;

            if (visited.Contains(required))
            {
                Console.WriteLine($"Pair found: {required} + {number} = {target}");
                return true;
            }
            visited.Add(number);
        }
        Console.WriteLine("No pair found.");

        return false;
    }
}