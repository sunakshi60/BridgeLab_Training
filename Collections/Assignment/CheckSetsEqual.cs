using System;
using System.Collections.Generic;

public class CheckSetsEqual
{
    public static bool Solve(HashSet<int> set1, HashSet<int> set2)
    {
        return set1.SetEquals(set2);
    }
}