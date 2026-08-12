using System;


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=================================");
        Console.WriteLine("     C# COLLECTIONS PRACTICE");
        Console.WriteLine("=================================");

        // List
        ListExample listExample = new ListExample();
        listExample.Run();

        // LinkedList
        LinkedListExample linkedListExample =
            new LinkedListExample();
        linkedListExample.Run();

        // Set
        SetExample setExample = new SetExample();
        setExample.Run();

        // Queue
        QueueExample queueExample = new QueueExample();
        queueExample.Run();

        // Deque
        DequeExample dequeExample = new DequeExample();
        dequeExample.Run();

        // Map
        MapExample mapExample = new MapExample();
        mapExample.Run();

        Console.WriteLine("\n=================================");
        Console.WriteLine("       PRACTICE COMPLETED");
        Console.WriteLine("=================================");

        Console.ReadLine();
    }
}