using System;
using System.Collections;
using System.Collections.Generic;
public class ReverseList
{
    public static void Solve()
    {
        ReverseArrayList();
        ReverseLinkedList();
    }

    static void ReverseArrayList()
    {
        ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
        int start = 0;
        int end = list.Count - 1;

        while (start < end)
        {
            object temp = list[start];
            list[start] = list[end];
            list[end] = temp;

            start++;
            end--;
        }

        Console.WriteLine("Reversed ArrayList:");

        foreach (object item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void ReverseLinkedList()
    {
        LinkedList<int> list = new LinkedList<int>(
              new int[] { 1, 2, 3, 4, 5 }
            );

        LinkedList<int> reversed = new LinkedList<int>();
        LinkedListNode<int> current = list.Last;

        while (current != null)
        {
            reversed.AddLast(current.Value);
            current = current.Previous;
        }

        Console.WriteLine("Reversed LinkedList:");
        foreach (int item in reversed)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}