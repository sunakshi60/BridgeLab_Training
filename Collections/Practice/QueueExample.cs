using System;
using System.Collections.Generic;

public class QueueExample
{
    public void Run()
    {
        Console.WriteLine("\n===== QUEUE =====");

        Queue<string> customers = new Queue<string>();

        customers.Enqueue("Sakshi");
        customers.Enqueue("Rahul");
        customers.Enqueue("Ananya");

        Console.WriteLine("Queue:");
        Display(customers);

        Console.WriteLine("\nFront element: " + customers.Peek());

        Console.WriteLine("Contains Rahul: " + customers.Contains("Rahul"));

        string removed = customers.Dequeue();

        Console.WriteLine("\nRemoved: " + removed);

        Console.WriteLine("\nQueue after Dequeue:");
        Display(customers);

        Console.WriteLine("\nCount: " + customers.Count);
    }

    private void Display(Queue<string> queue)
    {
        foreach (string item in queue)
        {
            Console.WriteLine(item);
        }
    }
}