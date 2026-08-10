using System;
using System.Collections.Generic;

public class UnionIntersection
{
    public static HashSet<int> FindUnion(
        HashSet<int> set1,
        HashSet<int> set2)
    {
        HashSet<int> union = new HashSet<int>(set1);
        foreach (int item in set2)
        {
            union.Add(item);
        }
        return union;
    }

    public static HashSet<int> FindIntersection(
        HashSet<int> set1,
        HashSet<int> set2)
    {
        HashSet<int> intersection = new HashSet<int>();

        foreach (int item in set1)
        {
            if (set2.Contains(item))
            {
                intersection.Add(item);
            }
        }
        return intersection;
    }
}