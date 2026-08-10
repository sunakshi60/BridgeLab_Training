using System;
using System.Collections.Generic;

public class SetToSortedList
{
    public static List<int> Solve(HashSet<int> set)
    {
        List<int> result = new List<int>();
        foreach (int item in set)
        {
            result.Add(item);
        }
        for (int i = 0; i < result.Count - 1; i++)
        {
            for (int j = 0; j < result.Count - i - 1; j++)
            {
                if (result[j] > result[j + 1])
                {
                    int temp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = temp;
                }
            }
        }
        return result;
    }
}