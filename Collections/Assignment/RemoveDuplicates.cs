using System;
using System.Collections.Generic;

public class RemoveDupliactes
{
    public static List<int> Solve(List<int> list)
    {
        List<int> result = new List<int>();
        HashSet<int> seen = new HashSet<int>();

        foreach(int item in list)
        {
            if (!seen.Contains(item))
            {
                seen.Add(item);
                result.Add(item);
            }
        }
        return result;
    }
}