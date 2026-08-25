using ChatApplicationMessageStore;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ChatAppTests
{
    [TestFixture]
    public class ChatApplicationTests
    {
        private ChatApplicationService chat;

        [SetUp]
        public void Setup()
        {
            chat = new ChatApplicationService();
        }

        [Test]
        public void AddContact_ShouldAddContact()
        {
            Contact contact = new Contact(1, "Preeti");
            chat.AddContact(contact);
            Contact result = chat.GetContact(1);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Name, Is.EqualTo("Preeti"));
        }

        [Test]
        public void CreateConversation_ShouldCreateConversation()
        {
            chat.AddContact(new Contact(1, "Preeti"));
            Conversation conversation = chat.CreateConversation(101, 1);
            Assert.That(conversation, Is.Not.Null);
            Assert.That(conversation.ChatId, Is.EqualTo(101));
            Assert.That(conversation.ContactName, Is.EqualTo("Preeti"));
        }

        [Test]
        public void SendMessage_ShouldAddMessageToQueue()
        {
            chat.AddContact(new Contact(1, "Preeti"));
            chat.CreateConversation(101, 1);
            Message message = chat.SendMessage(101, 1, "Hello", new DateTime(2026, 8, 24, 10, 0, 0));
            Assert.That(message, Is.Not.Null);
            Assert.That(message.Text, Is.EqualTo("Hello"));
            Assert.That(chat.DeliveryQueueCount(), Is.EqualTo(1));
        }

        [Test]
        public void DeliverNextMessage_ShouldDeliverMessage()
        {
            chat.AddContact(new Contact(1, "Preeti"));
            chat.CreateConversation(101, 1);
            chat.SendMessage(101, 1, "Hello", new DateTime(2026, 8, 24, 10, 0, 0));
            Message message = chat.DeliverNextMessage();
            Assert.That(message, Is.Not.Null);
            Assert.That(message.Delivered, Is.True);
            Assert.That(chat.DeliveryQueueCount(), Is.EqualTo(0));
        }

        [Test]
        public void EmptyDeliveryQueue_ShouldReturnNull()
        {
            Message message = chat.DeliverNextMessage();
            Assert.That(message, Is.Null);
        }
        [Test]
        public void StoreDeliveredMessage_ShouldAddMessageToConversation()
        {
            chat.AddContact(new Contact(1, "Preeti"));
            chat.CreateConversation(101, 1);
            Message message = chat.SendAndDeliver(101, 1, "Hello Preeti", new DateTime(2026, 8, 24, 10, 0, 0));
            Conversation conversation = chat.GetConversation(101);
            Assert.That(conversation.Messages.Count, Is.EqualTo(1));
            Assert.That(conversation.Messages.GetLast().Text, Is.EqualTo("Hello Preeti"));
        }

        [Test]
        public void NewMessage_ShouldMoveConversationToFront()
        {
            chat.AddContact(new Contact(1, "Preeti"));
            chat.AddContact(new Contact(2, "Anu"));

            chat.CreateConversation(101, 1);
            chat.CreateConversation(102, 2);

            chat.SendAndDeliver(101, 1, "Hello Preeti", new DateTime(2026, 8, 24, 10, 0, 0));
            chat.SendAndDeliver(102, 2, "Hello Anu", new DateTime(2026, 8, 24, 11, 0, 0));

            chat.SendAndDeliver(101, 1, "How are you?", new DateTime(2026, 8, 24, 12, 0, 0));
            List<Conversation> conversations = chat.GetConversationsForward();

            Assert.That(conversations[0].ChatId, Is.EqualTo(101));
        }


        [Test]
        public void SortConversations_ShouldReturnLatestFirst()
        {
            chat.AddContact(new Contact(1, "Preeti"));
            chat.AddContact(new Contact(2, "Anu"));
            chat.AddContact(new Contact(3, "Nancy"));

            chat.CreateConversation(101, 1);
            chat.CreateConversation(102, 2);
            chat.CreateConversation(103, 3);

            chat.SendAndDeliver(101, 1, "Message 1", new DateTime(2026, 8, 24, 10, 0, 0));
            chat.SendAndDeliver(102, 2, "Message 2", new DateTime(2026, 8, 24, 12, 0, 0));
            chat.SendAndDeliver(103, 3, "Message 3", new DateTime(2026, 8, 24, 11, 0, 0));

            List<Conversation> result = chat.GetSortedConversations();

            Assert.That(result[0].ChatId, Is.EqualTo(102));

            Assert.That(result[1].ChatId, Is.EqualTo(103));

            Assert.That(result[2].ChatId, Is.EqualTo(101));
        }

        [Test]
        public void EmojiNavigation_ShouldCycleThroughEmojis()
        {
            chat.AddEmoji("Happy");
            chat.AddEmoji("Sad");
            chat.AddEmoji("Angry");

            string first = chat.NextEmoji();
            string second = chat.NextEmoji();
            string third = chat.NextEmoji();
            string fourth = chat.NextEmoji();

            Assert.That(first, Is.EqualTo("Happy"));
            Assert.That(second, Is.EqualTo("Sad"));
            Assert.That(third, Is.EqualTo("Angry"));
            Assert.That(fourth, Is.EqualTo("Happy"));
        }

        [Test]
        public void MarkAsRead_ShouldPushLastMessage()
        {
            chat.AddContact(new Contact(1, "Preeti"));
            chat.CreateConversation(101, 1);

            chat.SendAndDeliver(101, 1, "Hello", new DateTime(2026, 8, 24, 10, 0, 0));

            chat.MarkAsRead(101);

            Message message = chat.GoToLastRead();

            Assert.That(message, Is.Not.Null);
        }

        [Test]
        public void SearchContact_ShouldFindContactAlphabetically()
        {
            chat.AddContact(new Contact(1, "Preeti"));
            chat.AddContact(new Contact(2, "Anu"));
            chat.AddContact(new Contact(3, "Nancy"));

            Contact result = chat.SearchContact("Nancy");

            Assert.That(result, Is.Not.Null);
            Assert.That(result.ContactId, Is.EqualTo(3));
            Assert.That(result.Name, Is.EqualTo("Nancy"));
        }

        [Test]
        public void IntegratedWorkflow_SendDeliverReadSearch_ShouldWork()
        {
            chat.AddContact(new Contact(1, "Preeti"));
            chat.CreateConversation(101, 1);

            Message message = chat.SendAndDeliver(101, 1, "Hello Preeti", new DateTime(2026, 8, 24, 10, 0, 0));

            chat.MarkAsRead(101);

            Message lastRead = chat.GoToLastRead();

            Contact contact = chat.SearchContact("Preeti");

            Conversation conversation = chat.GetConversation(101);

            Assert.That(message, Is.Not.Null);
            Assert.That(message.Delivered, Is.True);
            Assert.That(lastRead.Text, Is.EqualTo("Hello Preeti"));
            Assert.That(contact.Name, Is.EqualTo("Preeti"));
            Assert.That(conversation.Messages.Count, Is.EqualTo(1));
            Assert.That(chat.DeliveryQueueCount(), Is.EqualTo(0));
        }

        [Test]
        public void IntegratedWorkflow_MultipleChatsAndSorting_ShouldWork()
        {
            chat.AddContact(new Contact(1, "Preeti"));
            chat.AddContact(new Contact(2, "Anu"));
            chat.AddContact(new Contact(3, "Nancy"));

            chat.CreateConversation(101, 1);
            chat.CreateConversation(102, 2);
            chat.CreateConversation(103, 3);

            chat.SendAndDeliver(101, 1, "Hello Preeti", new DateTime(2026, 8, 24, 10, 0, 0));

            chat.SendAndDeliver(102, 2, "Hello Anu", new DateTime(2026, 8, 24, 11, 0, 0));

            chat.SendAndDeliver(103, 3, "Hello Nancy", new DateTime(2026, 8, 24, 12, 0, 0));

            chat.SendAndDeliver(101, 1, "How are you?", new DateTime(2026, 8, 24, 13, 0, 0));

            List<Conversation> result = chat.GetSortedConversations();

            Assert.That(result[0].ContactName, Is.EqualTo("Preeti"));

            Assert.That(result[1].ContactName, Is.EqualTo("Nancy"));

            Assert.That(result[2].ContactName, Is.EqualTo("Anu"));

            Assert.That(chat.GetConversation(101).Messages.Count, Is.EqualTo(2));

            Assert.That(chat.DeliveryQueueCount(), Is.EqualTo(0));
        }
    }
}