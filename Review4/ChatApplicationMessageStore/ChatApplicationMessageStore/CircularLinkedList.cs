using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApplicationMessageStore
{
    public class EmojiNode
    {
        public string Data;
        public EmojiNode Next;
        public EmojiNode(string data)
        {
            Data = data;
            Next = null;
        }
    }

    public class CircularLinkedList
    {
        private EmojiNode current;
        private int count;
        public int Count { get { return count; } }

        public void Add(string emoji)
        {
            EmojiNode newNode = new EmojiNode(emoji);
            if (current == null)
            {
                current = newNode;
                current.Next = newNode;
            }
            else
            {
                newNode.Next = current.Next;
                current.Next = newNode;
                current = newNode;
            }
            count++;
        }

        public string Next()
        {
            if (current == null)
            {
                return null;
            }
            current = current.Next;
            return current.Data;
        }

        public bool IsEmpty()
        {
            return current == null;
        }
    }
}