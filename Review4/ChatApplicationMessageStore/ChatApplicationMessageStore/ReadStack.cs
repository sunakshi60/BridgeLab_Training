using System.Collections.Generic;
using System.Reflection;

namespace ChatApplicationMessageStore
{
    public class StackNode
    {
        public Message Data;
        public StackNode Next;
        public StackNode(Message data)
        {
            Data = data;
            Next = null;
        }
    }

    public class MessageStack
    {
        private StackNode top;
        private int count;
        public int Count
        {
            get { return count; }
        }

        public void Push(Message message)
        {
            StackNode newNode = new StackNode(message);
            newNode.Next = top;
            top = newNode;
            count++;
        }

        public Message Pop()
        {
            if (top == null)
            {
                return null;
            }
            Message message = top.Data;
            top = top.Next;
            count--;
            return message;
        }

        public Message Peek()
        {
            if (top == null)
            {
                return null;
            }
            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}
