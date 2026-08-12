using System;
using System.Collections.Generic;

public class LinkedListExample
{
    public void Run()
    {
        Console.WriteLine("\n===== LINKED LIST =====");

        LinkedList<string> cities = new LinkedList<string>();

        cities.AddLast("Delhi");
        cities.AddLast("Mumbai");
        cities.AddLast("Chandigarh");

        Console.WriteLine("Initial LinkedList:");
        Display(cities);

        cities.AddFirst("Shimla");

        Console.WriteLine("\nAfter AddFirst:");
        Display(cities);

        LinkedListNode<string>? node = cities.Find("Mumbai");

        if (node != null)
        {
            cities.AddBefore(node, "Pune");
        }

        Console.WriteLine("\nAfter AddBefore Mumbai:");
        Display(cities);

        node = cities.Find("Mumbai");

        if (node != null)
        {
            cities.AddAfter(node, "Bangalore");
        }

        Console.WriteLine("\nAfter AddAfter Mumbai:");
        Display(cities);

        cities.RemoveFirst();

        Console.WriteLine("\nAfter RemoveFirst:");
        Display(cities);

        cities.RemoveLast();

        Console.WriteLine("\nAfter RemoveLast:");
        Display(cities);

        Console.WriteLine("\nContains Delhi: " + cities.Contains("Delhi"));

        Console.WriteLine("First: " + cities.First?.Value);
        Console.WriteLine("Last: " + cities.Last?.Value);
    }

    private void Display(LinkedList<string> list)
    {
        foreach (string item in list)
        {
            Console.WriteLine(item);
        }
    }
}