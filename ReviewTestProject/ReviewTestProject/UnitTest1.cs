using FraudDetection;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FraudDetection.Tests
{
    [TestFixture]
    public class TransactionTests
    {
        [Test]
        public void ValidTransaction_ShouldParseCorrectly()
        {
            string log = "CARD:4532-XXXX-XXXX-1129 | MCC:5411 | AMT:245.50 | TS:2026-08-14T13:22:05";

            Result result = TransactionParser.Parse(log);

            Assert.That(result.Success, Is.True);

            Assert.That(result.transaction.CardNumber, Is.EqualTo("4532-XXXX-XXXX-1129"));

            Assert.That(result.transaction.MCC,Is.EqualTo("5411"));

            Assert.That( result.transaction.Amount,Is.EqualTo(245.50m));

            Assert.That(result.transaction.Timestamp,Is.EqualTo(new DateTime(
                        2026,
                        8,
                        14,
                        13,
                        22,
                        5)));
        }

        [Test]
        public void MissingTimestamp_ShouldBeRejected()
        {
            string log ="CARD:4532-XXXX-XXXX-1129 | MCC:5411 | AMT:245.50";

            Result result = TransactionParser.Parse(log);

            Assert.That(result.Success, Is.False);
            Assert.That(result.transaction, Is.Null);
        }

        [Test]
        public void ExtraWhitespace_ShouldBeRejected()
        {
            string log = "CARD:4532-XXXX-XXXX-1129  | MCC:5411 | AMT:245.50 | TS:2026-08-14T13:22:05";

            Result result = TransactionParser.Parse(log);

            Assert.That(result.Success, Is.False);
        }

        [Test]
        public void WrongDateFormat_ShouldBeRejected()
        {
            string log ="CARD:4532-XXXX-XXXX-1129 | MCC:5411 | AMT:245.50 | TS:14/08/2026 13:22:05";

            Result result = TransactionParser.Parse(log);

            Assert.That(result.Success, Is.False);
        }

        [Test]
        public void InvalidCard_ShouldBeRejected()
        {
            string log = "CARD:4532-1234-XXXX-1129 | MCC:5411 | AMT:245.50 | TS:2026-08-14T13:22:05";

            Result result =TransactionParser.Parse(log);

            Assert.That(result.Success, Is.False);
        }

        [Test]
        public void FourTransactionsWithinTenMinutes_ShouldBeSuspicious()
        {
            List<Transaction> transactions = new List<Transaction>();

            transactions.Add(CreateTransaction("13:01:00"));

            transactions.Add(CreateTransaction("13:03:00"));

            transactions.Add(CreateTransaction("13:06:00"));

            transactions.Add(CreateTransaction("13:09:00"));

            bool result = FraudDetector.IsSuspicious(transactions);

            Assert.That(result, Is.True);
        }

        [Test]
        public void TransactionsOutsideTenMinutes_ShouldNotBeSuspicious()
        {
            List<Transaction> transactions = new List<Transaction>();

            transactions.Add(CreateTransaction("13:01:00"));

            transactions.Add( CreateTransaction("13:03:00"));

            transactions.Add( CreateTransaction("13:06:00"));

            transactions.Add(CreateTransaction("13:12:01"));

            bool result = FraudDetector.IsSuspicious(transactions);

            Assert.That(result, Is.False);
        }

        [Test]
        public void MultipleCards_ShouldBeCheckedSeparately()
        {
            List<Transaction> transactions =new List<Transaction>();

            transactions.Add(CreateTransaction("13:01:00","4532-XXXX-XXXX-1129"));

            transactions.Add(CreateTransaction( "13:03:00","4532-XXXX-XXXX-1129"));

            transactions.Add(CreateTransaction("13:06:00","4532-XXXX-XXXX-1129"));

            transactions.Add(CreateTransaction("13:09:00","4532-XXXX-XXXX-1129"));

            transactions.Add(CreateTransaction( "13:01:00","5555-XXXX-XXXX-9999"));

            transactions.Add(CreateTransaction("13:03:00", "5555-XXXX-XXXX-9999"));

            List<string> result =FraudDetector.FindErrorCards(transactions);

            Assert.That(result.Count,Is.EqualTo(1));

            Assert.That(result.Contains("4532-XXXX-XXXX-1129"),Is.True);

            Assert.That(result.Contains("5555-XXXX-XXXX-9999"),Is.False);
        }

        [Test]
        public void MCCStatistics_ShouldBeCorrect()
        {
            List<Transaction> transactions =new List<Transaction>();

            transactions.Add(CreateTransaction("13:01:00","4532-XXXX-XXXX-1129","5411",100));

            transactions.Add(CreateTransaction("13:05:00","4532-XXXX-XXXX-1129","5411",200));

            transactions.Add(CreateTransaction("14:00:00","5555-XXXX-XXXX-9999","5812",300));

            List<Merchant> result = MerchantAnalyzer.GetStatistics(transactions);

            Merchant merchant = result.First(x => x.MCC == "5411");

            Assert.That(merchant.TotalSpend,Is.EqualTo(300));

            Assert.That(merchant.AvgTransaction,Is.EqualTo(150));

            Assert.That(merchant.TransactionCount,Is.EqualTo(2));

            Merchant merchant5812 = result.First(x => x.MCC == "5812");

            Assert.That(merchant5812.TotalSpend,Is.EqualTo(300));

            Assert.That(merchant5812.AvgTransaction,Is.EqualTo(300));

            Assert.That(merchant5812.TransactionCount,Is.EqualTo(1));
        }

        [Test]
        public void Transaction_ShouldBeStoredInCorrectHour()
        {
            TransactionStore<Transaction> store = new TransactionStore<Transaction>();

            Transaction transaction =
                new Transaction(
                    "4532-XXXX-XXXX-1129",
                    "5411",
                    245.50m,
                    new DateTime(
                        2026,
                        8,
                        14,
                        13,
                        22,
                        5));

            store.Add(transaction);

            List<Transaction> result =
                store.GetByHour(
                    new DateTime(
                        2026,
                        8,
                        14,
                        13,
                        0,
                        0));

            Assert.That(result.Count,Is.EqualTo(1));

            Assert.That(result[0],Is.EqualTo(transaction));
        }

        private Transaction CreateTransaction(string time)
        {
            DateTime timestamp =DateTime.Parse("2026-08-14 " + time);

            return new Transaction(
                "4532-XXXX-XXXX-1129",
                "5411",
                100,
                timestamp);
        }

        private Transaction CreateTransaction(string time,string card)
        {
            DateTime timestamp =DateTime.Parse("2026-08-14 " + time);

            return new Transaction(
                card,
                "5411",
                100,
                timestamp);
        }

        private Transaction CreateTransaction(string time,string card,string mcc,decimal amount)
        {
            DateTime timestamp = DateTime.Parse("2026-08-14 " + time);

            return new Transaction(
                card,
                mcc,
                amount,
                timestamp);
        }
    }
}