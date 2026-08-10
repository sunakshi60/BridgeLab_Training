using System;
using System.Collections.Generic;

public class ReverseQueue
{
    public static void Solve(Queue<int> queue)
    {
        if (queue.Count == 0)
        {
            return;
        }
        int item = queue.Dequeue();
        Solve(queue);
        queue.Enqueue(item);
    }
}