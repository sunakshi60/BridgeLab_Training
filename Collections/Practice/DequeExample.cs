using System;
using System.Collections.Generic;


public class DequeExample
{
    public void Run()
    {
        Console.WriteLine("\n===== DEQUE =====");

        LinkedList<int> deque = new LinkedList<int>();

        deque.AddLast(20);
        deque.AddLast(30);

        deque.AddFirst(10);

        Console.WriteLine("Deque:");
        Display(deque);

        deque.AddFirst(5);

        deque.AddLast(40);

        Console.WriteLine("\nAfter adding from both ends:");
        Display(deque);

        int first = deque.First!.Value;
        deque.RemoveFirst();

        Console.WriteLine("\nRemoved from front: " + first);

        int last = deque.Last!.Value;
        deque.RemoveLast();

        Console.WriteLine("Removed from rear: " + last);

        Console.WriteLine("\nDeque after removals:");
        Display(deque);

        Console.WriteLine("\nFront: " + deque.First?.Value);

        Console.WriteLine("Rear: " + deque.Last?.Value);
    }

    private void Display(LinkedList<int> deque)
    {
        foreach (int number in deque)
        {
            Console.WriteLine(number);
        }
    }
}