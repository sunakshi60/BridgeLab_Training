using System;
using System.Collections.Generic;

namespace ChatApplicationMessageStore
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatApplicationService chat = new ChatApplicationService();

            Console.WriteLine("WELCOME TO CHAT APPLICATION");
            Console.WriteLine();

            Console.WriteLine("ADDING CONTACTS");

            chat.AddContact(new Contact(1, "Preeti"));
            chat.AddContact(new Contact(2, "Anu"));
            chat.AddContact(new Contact(3, "Nancy"));

            Console.WriteLine("Contacts added.");
            Console.WriteLine();


            Console.WriteLine("CREATING CONVERSATIONS");

            chat.CreateConversation(101, 1);
            chat.CreateConversation(102, 2);
            chat.CreateConversation(103, 3);

            Console.WriteLine("Conversations created.");
            Console.WriteLine();


            Console.WriteLine("ADDING EMOJIS");

            chat.AddEmoji("Happy");
            chat.AddEmoji("Sad");
            chat.AddEmoji("Angry");
            chat.AddEmoji("Cry");
            chat.AddEmoji("Irritate");

            Console.WriteLine("Emojis added.");
            Console.WriteLine();


            Console.WriteLine("SENDING MESSAGES");

            chat.SendMessage(101, 1, "Hello Preeti", new DateTime(2026, 8, 24, 10, 0, 0));

            chat.SendMessage(102, 2, "Hello Anu", new DateTime(2026, 8, 24, 11, 0, 0));

            chat.SendMessage(103, 3, "Hello Nancy", new DateTime(2026, 8, 24, 12, 0, 0));

            Console.WriteLine("Messages added to delivery queue.");
            Console.WriteLine();


            Console.WriteLine("DELIVERING MESSAGES");

            Message message1 = chat.DeliverNextMessage();
            Message message2 = chat.DeliverNextMessage();
            Message message3 = chat.DeliverNextMessage();

            chat.StoreDeliveredMessage(101, message1);
            chat.StoreDeliveredMessage(102, message2);
            chat.StoreDeliveredMessage(103, message3);

            Console.WriteLine("Messages delivered.");
            Console.WriteLine();


            Console.WriteLine("MESSAGES IN CHAT 101");

            Conversation chat101 = chat.GetConversation(101);

            foreach (Message message in chat101.Messages.GetAll())
            {
                Console.WriteLine(message.MessageId +" - " + message.Text + " - Delivered: " + message.Delivered);
            }

            Console.WriteLine();

            Console.WriteLine("NEW MESSAGE IN CHAT 101");

            chat.SendAndDeliver( 101, 1, "How are you?", new DateTime(2026, 8, 24, 13, 0, 0));

            Console.WriteLine("New message delivered.");
            Console.WriteLine();

            Console.WriteLine("CONVERSATIONS FORWARD");

            List<Conversation> forward = chat.GetConversationsForward();

            foreach (Conversation conversation in forward)
            {
                Console.WriteLine(conversation.ChatId + " - " + conversation.ContactName);
            }

            Console.WriteLine();

            Console.WriteLine("CONVERSATIONS BACKWARD");

            List<Conversation> backward = chat.GetConversationsBackward();

            foreach (Conversation conversation in backward)
            {
                Console.WriteLine(conversation.ChatId + " - " +conversation.ContactName );
            }

            Console.WriteLine();

            Console.WriteLine("SORTED CONVERSATIONS");

            List<Conversation> sorted = chat.GetSortedConversations();

            foreach (Conversation conversation in sorted)
            {
                Console.WriteLine( conversation.ChatId +  " - " +conversation.ContactName + " - " + conversation.LastActivity);
            }

            Console.WriteLine();

            Console.WriteLine("EMOJI NAVIGATION");

            Console.WriteLine(chat.NextEmoji());
            Console.WriteLine(chat.NextEmoji());
            Console.WriteLine(chat.NextEmoji());
            Console.WriteLine(chat.NextEmoji());

            Console.WriteLine();


            Console.WriteLine("LAST READ MESSAGE");

            chat.MarkAsRead(101);

            Message lastRead = chat.GoToLastRead();

            if (lastRead != null)
            {
                Console.WriteLine(lastRead.MessageId + " - " + lastRead.Text);
            }
            else
            {
                Console.WriteLine("No last-read message.");
            }

            Console.WriteLine();

            Console.WriteLine("CONTACT SEARCH");

            Contact contact = chat.SearchContact("Nancy");

            if (contact != null)
            {
                Console.WriteLine( contact.ContactId + " - " + contact.Name);
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }

            Console.WriteLine();

            Console.WriteLine("INVALID CONTACT SEARCH");

            Contact invalidContact = chat.SearchContact("Sakshi");

            if (invalidContact == null)
            {
                Console.WriteLine("Contact not found.");
            }

            Console.WriteLine();

            Console.WriteLine("QUEUE STATUS");

            Console.WriteLine("Messages waiting: " + chat.DeliveryQueueCount());

            Console.WriteLine();

            Console.WriteLine("CONVERSATION COUNT");

            Console.WriteLine("Total conversations: " +chat.ConversationCount());

            Console.WriteLine();

            Console.WriteLine("APPLICATION COMPLETED");
        }
    }
}