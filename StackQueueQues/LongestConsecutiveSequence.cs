using System;
using System.Collections.Generic;

public class LongestConsecutiveSequence
{
    public int FindLongestSequence(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return 0;
        }
        HashSet<int> set = new HashSet<int>();
        foreach (int number in numbers)
        {
            set.Add(number);
        }
        int longestLength = 0;
        foreach (int number in set)
        {
            if (!set.Contains(number - 1))
            {
                int currentNumber = number;
                int currentLength = 1;
                while (set.Contains(currentNumber + 1))
                {
                    currentNumber++;
                    currentLength++;
                }
                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                }
            }
        }
        return longestLength;
    }
}