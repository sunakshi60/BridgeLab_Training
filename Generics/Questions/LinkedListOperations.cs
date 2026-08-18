using System;
using System.Collections.Generic;

namespace Questions
{
    public class LinkedListOperations
    {
        private LinkedList<int> numbers;

        public LinkedListOperations()
        {
            numbers = new LinkedList<int>();

            numbers.AddLast(10);
            numbers.AddLast(20);
            numbers.AddLast(30);
            numbers.AddLast(20);
            numbers.AddLast(40);
            numbers.AddLast(20);
        }

        public void RemoveAllOccurrences(int value)
        {
            LinkedListNode<int>? current = numbers.First;

            while (current != null)
            {
                LinkedListNode<int>? next = current.Next;

                if (current.Value == value)
                {
                    numbers.Remove(current);
                }

                current = next;
            }
        }

        public void Display()
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
        }
    }
}