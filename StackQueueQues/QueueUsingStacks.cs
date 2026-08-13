using System;
using System.Collections.Generic;

namespace StackQueueQues
{
    public class QueueUsingStacks
    {
        private Stack<int> stack1 = new Stack<int>();
        private Stack<int> stack2 = new Stack<int>();

        public void Enqueue(int value)
        {
            stack1.Push(value);
            Console.WriteLine($"{value} added to Queue");
        }

        public int Dequeue()
        {
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
            if (stack2.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty");
            }
            return stack2.Pop();
        }
        public bool IsEmpty()
        {
            return stack1.Count == 0 && stack2.Count == 0;
        }
    }
}