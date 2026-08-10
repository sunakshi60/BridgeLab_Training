using System;
using System.Collections.Generic;

public class FindFrequency
{
    public static Dictionary<string,int> Solve(List <string> list)
    {
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        foreach(string item in list)
        {
            if (frequency.ContainsKey(item))
            {
                frequency[item]++;
            }
            else
            {
                frequency[item] = 1;
            }
        }
        return frequency;
    }
}