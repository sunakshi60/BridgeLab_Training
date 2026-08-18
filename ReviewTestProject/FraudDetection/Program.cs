using System;
using System.Collections.Generic;
using FraudDetection;

namespace FraudDetectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TransactionStore<Transaction> store = new TransactionStore<Transaction>();

            string[] logs =
            {
                "CARD:4532-XXXX-XXXX-1129 | MCC:5411 | AMT:245.50 | TS:2026-08-14T13:01:00",
                "CARD:4532-XXXX-XXXX-1129 | MCC:5411 | AMT:100.00 | TS:2026-08-14T13:03:00",
                "CARD:4532-XXXX-XXXX-1129 | MCC:5411 | AMT:200.00 | TS:2026-08-14T13:06:00",
                "CARD:4532-XXXX-XXXX-1129 | MCC:5411 | AMT:150.00 | TS:2026-08-14T13:09:00",
                "CARD:5555-XXXX-XXXX-9999 | MCC:5812 | AMT:300.00 | TS:2026-08-14T14:10:00",
                "CARD:5555-XXXX-XXXX-9999 | MCC:5812 | AMT:400.00 | TS:2026-08-14T14:20:00",
                "CARD:4532-XXXX-XXXX-1129 | MCC:5411 | AMT:245.50"
            };

            foreach (string log in logs)
            {
                Result result = TransactionParser.Parse(log);
                if (result.Success)
                {
                    store.Add(result.transaction);
                    Console.WriteLine("Transaction Added");
                }
                else
                {
                    Console.WriteLine("Transaction Rejected: " +result.ErrorMessage);
                }
            }

            List<Transaction> transactions = store.GetAllTransactions();
            Console.WriteLine();
            Console.WriteLine("Suspicious Cards");
            List<string> errorCards =FraudDetector.FindErrorCards(transactions);
            foreach (string card in errorCards)
            {
                Console.WriteLine(card);
            }
            Console.WriteLine();
            Console.WriteLine("Merchant Statistics");
            List<Merchant> merchants = MerchantAnalyzer.GetStatistics(transactions);
            foreach (Merchant merchant in merchants)
            {
                Console.WriteLine("MCC: " + merchant.MCC);
                Console.WriteLine("Total Spend: " + merchant.TotalSpend);
                Console.WriteLine("Average Transaction: " +merchant.AvgTransaction);
                Console.WriteLine("Transaction Count: " +merchant.TransactionCount);
                Console.WriteLine();
            }

            Console.WriteLine("Hourly Transactions");
            DateTime hour =new DateTime(2026, 8,14,13,0,0);
            List<Transaction> hourlyTransactions = store.GetByHour(hour);
            foreach (Transaction transaction in hourlyTransactions)
            {
                Console.WriteLine(transaction.CardNumber +" " +transaction.Amount +" " + transaction.Timestamp);
            }
            Console.ReadKey();
        }
    }
}