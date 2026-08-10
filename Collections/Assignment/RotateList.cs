using System;
using System.Collections.Generic;

public class RotateList
{
    public static List<int> Solve(List<int> list,int positions)
    {
        List<int> rotatedList = new List<int>();
        positions = positions % list.Count;
        for(int i = positions; i < list.Count; i++)
        {
            rotatedList.Add(list[i]);
        }
        for(int i = 0; i < positions; i++)
        {
            rotatedList.Add(list[i]);
        }
        return rotatedList;
    }
}