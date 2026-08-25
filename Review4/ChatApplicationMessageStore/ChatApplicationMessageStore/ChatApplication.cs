using System;
using System.Collections.Generic;

namespace ChatApplicationMessageStore
{
    public class ChatApplicationService
    {
        private HashMap<Contact> contacts;
        private HashMap<Conversation> conversations;
        private DoublyLinkedList conversationList;
        private MessageQueue deliveryQueue;
        private MessageStack lastReadStack;

        private CircularLinkedList emojis;

        private int nextMessageId;

        public ChatApplicationService()
        {
            contacts = new HashMap<Contact>(10);

            conversations = new HashMap<Conversation>(10);

            conversationList = new DoublyLinkedList();

            deliveryQueue = new MessageQueue();

            lastReadStack = new MessageStack();

            emojis = new CircularLinkedList();

            nextMessageId = 1;
        }

        public void AddContact(Contact contact)
        {
            contacts.Put(contact.ContactId, contact);
        }

        public Contact GetContact(int contactId)
        {
            return contacts.Get(contactId);
        }

        public void AddEmoji(string emoji)
        {
            emojis.Add(emoji);
        }

        public string NextEmoji()
        {
            return emojis.Next();
        }

        public Conversation CreateConversation(int chatId, int contactId)
        {
            if (conversations.ContainsKey(chatId))
            {
                return conversations.Get(chatId);
            }
            Contact contact = contacts.Get(contactId);
            if (contact == null)
            {
                return null;
            }
            Conversation conversation = new Conversation(chatId, contactId, contact.Name);
            conversations.Put(chatId, conversation);
            conversationList.AddLast(conversation);
            return conversation;
        }

        public Conversation GetConversation(int chatId)
        {
            return conversations.Get(chatId);
        }

        public Message SendMessage(int chatId, int senderId, string text, DateTime sentAt)
        {
            Conversation conversation = conversations.Get(chatId);
            if (conversation == null)
            {
                return null;
            }
            Message message = new Message(nextMessageId, senderId, text, sentAt);
            nextMessageId++;
            deliveryQueue.Enqueue(message);
            return message;
        }

        public Message DeliverNextMessage()
        {
            Message message = deliveryQueue.Dequeue();
            if (message == null)
            {
                return null;
            }
            message.Delivered = true;
            return message;
        }

        public bool StoreDeliveredMessage(int chatId, Message message)
        {
            Conversation conversation = conversations.Get(chatId);
            if (conversation == null)
            {
                return false;
            }
            conversation.AddMessage(message);
            conversationList.MoveToFront(conversation);
            return true;
        }

        public Message SendAndDeliver(int chatId, int senderId, string text, DateTime sentAt)
        {
            Message message = SendMessage(chatId, senderId, text, sentAt);
            if (message == null)
            {
                return null;
            }
            Message deliveredMessage = DeliverNextMessage();
            if (deliveredMessage != null)
            {
                StoreDeliveredMessage(chatId, deliveredMessage);
            }
            return deliveredMessage;
        }

        public void MarkAsRead(int chatId)
        {
            Conversation conversation = conversations.Get(chatId);
            if (conversation == null)
            {
                return;
            }
            if (conversation.Messages.IsEmpty())
            {
                return;
            }
            Message lastMessage = conversation.Messages.GetLast();
            lastReadStack.Push(lastMessage);
        }

        public Message GoToLastRead()
        {
            return lastReadStack.Pop();
        }

        public List<Conversation> GetConversationsForward()
        {
            return conversationList.GetForward();
        }

        public List<Conversation> GetConversationsBackward()
        {
            return conversationList.GetBackward();
        }

        public List<Conversation> GetSortedConversations()
        {
            List<Conversation> result = conversationList.GetForward();
            Sorting.SortConversations(result);
            return result;
        }

        public Contact SearchContact(string name)
        {
            List<Contact> contactsList = GetContactsAlphabetically();
            return Searching.BinarySearch(contactsList, name);
        }

        public List<Contact> GetContactsAlphabetically()
        {
            List<Contact> result = contacts.GetAllValues();
            for (int i = 0; i < result.Count - 1; i++)
            {
                int smallestIndex = i;
                for (int j = i + 1; j < result.Count;  j++)
                {
                    if (string.Compare(
                        result[j].Name,
                        result[smallestIndex].Name,
                        StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        smallestIndex = j;
                    }
                }
                Contact temp = result[i];
                result[i] = result[smallestIndex];
                result[smallestIndex] = temp;
            }
            return result;
        }

        public int DeliveryQueueCount()
        {
            return deliveryQueue.Count;
        }

        public int LastReadStackCount()
        {
            return lastReadStack.Count;
        }

        public int ConversationCount()
        {
            return conversationList.Count;
        }

        public bool IsEmojiListEmpty()
        {
            return emojis.IsEmpty();
        }
    }
}