using System;
using System.Collections.Generic;

public class InvertMap
{
    public static Dictionary<int, List<string>> Solve(Dictionary<string, int> map)
    {
        Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();
        foreach (var item in map)
        {
            string key = item.Key;
            int value = item.Value;
            if (inverted.ContainsKey(value))
            {
                inverted[value].Add(key);
            }
            else
            {
                inverted[value] = new List<string>();
                inverted[value].Add(key);
            }
        }
        return inverted;
    }
}