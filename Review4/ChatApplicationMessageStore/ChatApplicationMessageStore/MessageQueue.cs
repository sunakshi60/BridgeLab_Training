using ChatApplicationMessageStore;
using System.Collections.Generic;
using System.Reflection;

namespace ChatApplicationMessageStore
{
    public class QueueNode
    {
        public Message Data;
        public QueueNode Next;

        public QueueNode(Message data)
        {
            Data = data;
            Next = null;
        }
    }

    public class MessageQueue
    {
        private QueueNode front;
        private QueueNode rear;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public void Enqueue(Message message)
        {
            QueueNode newNode = new QueueNode(message);
            if (rear == null)
            {
                front = newNode;
                rear = newNode;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
            }
            count++;
        }

        public Message Dequeue()
        {
            if (front == null)
            {
                return null;
            }
            Message message = front.Data;
            front = front.Next;
            if (front == null)
            {
                rear = null;
            }
            count--;
            return message;
        }

        public Message Peek()
        {
            if (front == null)
            {
                return null;
            }
            return front.Data;
        }

        public bool IsEmpty()
        {
            return front == null;
        }
    }
}