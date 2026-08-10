using System;
using System.Collections.Generic;

public class NthElementFromEnd
{
    public static string Solve(LinkedList<string> list,int n)
    {
        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;

        for(int i = 0; i < n; i++)
        {
            if (first == null)
            {
                return "Invalid N";
            }
            first = first.Next;
        }
        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }
        return second.Value;
    }
}