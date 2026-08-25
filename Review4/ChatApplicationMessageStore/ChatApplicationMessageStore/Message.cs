using System;
using System.Collections.Generic;

namespace ChatApplicationMessageStore
{
    public class Message
    {
        public int MessageId;
        public int SenderId;
        public string Text;
        public DateTime SentAt;
        public bool Delivered;

        public Message(int messageId, int senderId, string text, DateTime sentAt)
        {
            MessageId = messageId;
            SenderId = senderId;
            Text = text;
            SentAt = sentAt;
            Delivered = false;
        }
        public override string ToString()
        {
            return MessageId + " - " + Text;
        }
    }
}


