using System;
using System.Collections.Generic;

public class CheckSubset
{
    public static bool Solve(HashSet<int> set1, HashSet<int> set2)
    {
        foreach (int item in set1)
        {
            if (!set2.Contains(item))
            {
                return false;
            }
        }
        return true;
    }
}