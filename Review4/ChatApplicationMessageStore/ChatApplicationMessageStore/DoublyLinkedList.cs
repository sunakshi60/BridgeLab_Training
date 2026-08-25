using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ChatApplicationMessageStore
{
    public class ConversationNode
    {
        public Conversation Data;
        public ConversationNode Next;
        public ConversationNode Previous;

        public ConversationNode(Conversation data)
        {
            Data = data;
            Next = null;
            Previous = null;
        }
    }
    public class DoublyLinkedList
    {
        private ConversationNode head;
        private ConversationNode tail;

        public int count;
        public int Count { get { return count; }  }

        public void AddLast(Conversation conversation)
        {
            ConversationNode newNode = new ConversationNode(conversation);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
            count++;
        }

        public void AddFirst(Conversation conversation)
        {
            ConversationNode newNode = new ConversationNode(conversation);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Previous = newNode;
                head = newNode;
            }
            count++;
        }

        public bool Remove(Conversation conversation)
        {
            ConversationNode current = head;
            while (current != null)
            {
                if (current.Data.ChatId == conversation.ChatId)
                {
                    if (current.Previous != null)
                    {
                        current.Previous.Next = current.Next;
                    }
                    else
                    {
                        head = current.Next;
                    }
                    if (current.Next != null)
                    {
                        current.Next.Previous = current.Previous;
                    }
                    else
                    {
                        tail = current.Previous;
                    }
                    count--;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void MoveToFront(Conversation conversation)
        {
            if (head != null &&
                head.Data.ChatId == conversation.ChatId)
            {
                return;
            }
            if (Remove(conversation))
            {
                AddFirst(conversation);
            }
        }

        public Conversation Find(int chatId)
        {
            ConversationNode current = head;
            while (current != null)
            {
                if (current.Data.ChatId == chatId)
                {
                    return current.Data;
                }
                current = current.Next;
            }
           return null;
        }

        public List<Conversation> GetForward()
        {
            List<Conversation> conversations = new List<Conversation>();
            ConversationNode current = head;
            while (current != null)
            {
                conversations.Add(current.Data);
                current = current.Next;
            }

            return conversations;
        }

        public List<Conversation> GetBackward()
        {
            List<Conversation> conversations = new List<Conversation>();
            ConversationNode current = tail;
            while (current != null)
            {
                conversations.Add(current.Data);
                current = current.Previous;
            }
            return conversations;
        }

        public bool IsEmpty()
        {
            return head == null;
        }
    }
}
