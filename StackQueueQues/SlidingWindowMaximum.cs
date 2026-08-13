using System;
using System.Collections.Generic;

public class SlidingWindowMaximum
{
    public int[] FindMaximum(int[] numbers, int k)
    {
        if (numbers == null || numbers.Length == 0 || k <= 0)
        {
            return Array.Empty<int>();
        }

        if (k > numbers.Length)
        {
            throw new ArgumentException(
                "Window size cannot be greater than array size.");
        }

        int n = numbers.Length;

        int[] result = new int[n - k + 1];

        LinkedList<int> deque = new LinkedList<int>();

        for (int i = 0; i < n; i++)
        {
            if (deque.Count > 0 &&
                deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            while (deque.Count > 0 &&
                   numbers[deque.Last.Value] <= numbers[i])
            {
                deque.RemoveLast();
            }

            deque.AddLast(i);

            if (i >= k - 1)
            {
                result[i - k + 1] =
                    numbers[deque.First.Value];
            }
        }

        return result;
    }
}