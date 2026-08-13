using System;
using System.Collections.Generic;

public class ZeroSumSubarray
{
    public void FindSubarrays(int[] numbers)
    {
       
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int sum = 0;

        map[0] = new List<int>();
        map[0].Add(-1);

        bool found = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];

            if (map.ContainsKey(sum))
            {
                found = true;

                foreach (int previousIndex in map[sum])
                {
                    Console.WriteLine(
                        $"Subarray: Index {previousIndex + 1} to {i}");

                    Console.Write("Elements: ");

                    for (int j = previousIndex + 1; j <= i; j++)
                    {
                        Console.Write(numbers[j] + " ");
                    }

                    Console.WriteLine();
                }
                map[sum].Add(i);
            }
            else
            {
                map[sum] = new List<int>();
                map[sum].Add(i);
            }
        }

        if (!found)
        {
            Console.WriteLine("No zero-sum subarray found.");
        }
    }
}