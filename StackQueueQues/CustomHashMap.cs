using System;

public class CustomHashMap
{
    private class Node
    {
        public int Key;
        public string Value;
        public Node Next;

        public Node(int key, string value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }
    private Node[] buckets;
    private int capacity;

    public CustomHashMap(int capacity)
    {
        this.capacity = capacity;
        buckets = new Node[capacity];
    }

    private int GetIndex(int key)
    {
        return Math.Abs(key) % capacity;
    }

    public void Put(int key, string value)
    {
        int index = GetIndex(key);
        Node current = buckets[index];
        while (current != null)
        {
            if (current.Key == key)
            {
                current.Value = value;
                return;
            }
            current = current.Next;
        }

        Node newNode = new Node(key, value);
        newNode.Next = buckets[index];
        buckets[index] = newNode;
    }

    public string Get(int key)
    {
        int index = GetIndex(key);
        Node current = buckets[index];
        while (current != null)
        {
            if (current.Key == key)
            {
                return current.Value;
            }

            current = current.Next;
        }

        return null;
    }

    public bool Remove(int key)
    {
        int index = GetIndex(key);

        Node current = buckets[index];
        Node previous = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (previous == null)
                {
                    buckets[index] = current.Next;
                }
                else
                {
                    previous.Next = current.Next;
                }

                return true;
            }

            previous = current;
            current = current.Next;
        }

        return false;
    }

    public void Display()
    {
        for (int i = 0; i < capacity; i++)
        {
            Console.Write($"Bucket {i}: ");
            Node current = buckets[i];
            while (current != null)
            {
                Console.Write(
                    $"[{current.Key}, {current.Value}] -> ");

                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}