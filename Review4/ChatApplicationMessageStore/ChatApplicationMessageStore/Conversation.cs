using System;
using System.Collections.Generic;
using System.Text;

namespace ChatApplicationMessageStore
{
    public class Conversation
    {
        public int ChatId { get; set; }
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public DateTime LastActivity { get; set; }

        public SinglyLinkedList Messages { get; set; }

        public Conversation(int chatId, int contactId, string contactName)
        {
            ChatId = chatId;
            ContactId = contactId;
            ContactName = contactName;
            LastActivity = DateTime.MinValue;
            Messages = new SinglyLinkedList();
        }

        public void AddMessage(Message message)
        {
            Messages.Add(message);
            LastActivity = message.SentAt;
        }

        public override string ToString()
        {
            return ChatId + " - " + ContactName;
        }
    }
}