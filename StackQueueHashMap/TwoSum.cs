using System;
using System.Collections.Generic;

public class TwoSum
{
    public int[] FindTwoSum(int[] numbers, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            int required = target - currentNumber;
            if (map.ContainsKey(required))
            {
                int previousIndex = map[required];
                return new int[]
                {
                    previousIndex,
                    i
                };
            }
            map[currentNumber] = i;
        }
        return Array.Empty<int>();
    }
}