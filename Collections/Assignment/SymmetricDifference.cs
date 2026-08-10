using System;
using System.Collections.Generic;

public class SymmetricDifference
{
    public static HashSet<int> Solve(HashSet<int> set1,HashSet<int> set2)
    {
        HashSet<int> result = new HashSet<int>();
        foreach (int item in set1)
        {
            if (!set2.Contains(item))
            {
                result.Add(item);
            }
        }
        foreach (int item in set2)
        {
            if (!set1.Contains(item))
            {
                result.Add(item);
            }
        }

        return result;
    }
}