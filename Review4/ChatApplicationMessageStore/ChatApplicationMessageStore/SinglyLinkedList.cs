using System;
using System.Collections.Generic;
using System.Reflection;

namespace ChatApplicationMessageStore
{
    public class MessageNode
    {
        public Message Data;
        public MessageNode Next;
        public MessageNode(Message data)
        {
            Data = data;
            Next = null;
        }
    }

    public class SinglyLinkedList
    {
        private MessageNode head;
        private MessageNode tail;
        private int count;
        public int Count { get { return count; } }

        public void Add(Message message)
        {
            MessageNode newNode = new MessageNode(message);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
            count++;
        }

        public Message Get(int index)
        {
            if (index < 0 || index >= count)
            {
                return null;
            }
            MessageNode current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public Message GetLast()
        {
            if (tail == null)
            {
                return null;
            }
            return tail.Data;
        }

        public List<Message> GetAll()
        {
            List<Message> messages = new List<Message>();
            MessageNode current = head;
            while (current != null)
            {
                messages.Add(current.Data);
                current = current.Next;
            }
            return messages;
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }
}
