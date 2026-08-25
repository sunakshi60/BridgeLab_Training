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
    }
}