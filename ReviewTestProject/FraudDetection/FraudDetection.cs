using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FraudDetection
{
    public class Transaction
    {
        public string CardNumber;
        public string MCC;
        public decimal Amount;
        public DateTime Timestamp;

        public Transaction(string cardNumber, string mcc, decimal amount, DateTime timestamp)
        {
            CardNumber = cardNumber;
            MCC = mcc;
            Amount = amount;
            Timestamp = timestamp;
        }
    }

    // result of Parsing a transaction log & tells whether transaction is valid or not
    public class Result
    {
        public bool Success;
        public Transaction transaction;
        public string ErrorMessage;

        //succesfully result when parsing is completed
        public static Result Valid(Transaction transaction)
        {
            return new Result
            {
                Success = true,
                transaction = transaction
            };
        }

        //unsuccessfully result with rejection
        public static Result Invalid(string message)
        {
            return new Result
            {
                Success = false,
                ErrorMessage = message
            };
        }
    }

    //Responsible for covert raw transaction to log strings
    //into Transaction objects after validate formate and data
    public static class TransactionParser
    {
        public static Result Parse(string mess)
        {
            if (string.IsNullOrWhiteSpace(mess))
            {
                return Result.Invalid("Invalid transaction");
            }
            //Regex validates
            Match match = Regex.Match(
                mess,
                @"^CARD:(?<card>\d{4}-XXXX-XXXX-\d{4}) \| MCC:(?<mcc>\d{4}) \| AMT:(?<amount>\d+\.\d{2}) \| TS:(?<timestamp>\d{4}-\d{2}-\d{2}T\d{2}:\d{2}:\d{2})$"
            );

            if (!match.Success)
            {
                return Result.Invalid("Invalid Transaction");
            }

            //Extract values by named groups
            string card = match.Groups["card"].Value;
            string mcc = match.Groups["mcc"].Value;
            string amountText = match.Groups["amount"].Value;
            string timestampText = match.Groups["timestamp"].Value;


            if (!decimal.TryParse(amountText, out decimal amount))
            {
                return Result.Invalid("Invalid amount");
            }

            if (!DateTime.TryParse(timestampText, out DateTime timestamp))
            {
                return Result.Invalid("Invalid Timestamp");
            }

            Transaction transaction = new Transaction(card, mcc, amount, timestamp);
            return Result.Valid(transaction);
        }
    }


    //Generic class stores by card number and by hour
    public class TransactionStore<T> where T : Transaction
    {
        private Dictionary<string, List<T>> transactionsByCard;
        private Dictionary<DateTime, List<T>> transactionsByHour;
        public TransactionStore()
        {
            transactionsByCard = new Dictionary<string, List<T>>();
            transactionsByHour = new Dictionary<DateTime, List<T>>();
        }

        public void Add(T transaction)
        {
            if (!transactionsByCard.ContainsKey(transaction.CardNumber))
            {
                transactionsByCard[transaction.CardNumber] = new List<T>();
            }
            transactionsByCard[transaction.CardNumber].Add(transaction);

            DateTime hour = HourBucket(transaction.Timestamp);
            if (!transactionsByHour.ContainsKey(hour))
            {
                transactionsByHour.Add(hour,new List<T>());
            }
            transactionsByHour[hour].Add(transaction);
        }

        public List<T> GetByCard(string cardNumber)
        {
            if (transactionsByCard.ContainsKey(cardNumber))
            {
                return transactionsByCard[cardNumber];
            }
            return new List<T>();
        }

        public List<T> GetByHour(DateTime time)
        {
            DateTime hour = HourBucket(time);
            if (transactionsByHour.ContainsKey(hour))
            {
                return transactionsByHour[hour];
            }
            return new List<T>();
        }

        public List<T> GetAllTransactions()
        {
            return transactionsByCard
                .Values
                .SelectMany(x => x)
                .ToList();
        }

        //covert timestamp into beginning of its hour
        public DateTime HourBucket(DateTime time)
        {
            return new DateTime(
                time.Year,
                time.Month,
                time.Day,
                time.Hour,
                0,
                0
            );
        }
    }

    // Represents statistical information for one Merchant Category Code
    public class Merchant
    {
        public string MCC { get; set; }
        public decimal TotalSpend { get; set; }
        public decimal AvgTransaction { get; set; }
        public int TransactionCount { get; set; }
    }

    //responsible for detecting suspicious transaction patterns and identify card
    public static class FraudDetector
    {
        //Checks whether a card has more than 3 transactions within 10 minutes time window
        public static bool IsSuspicious(List<Transaction> trans)
        {
            List<Transaction> sorted = trans.OrderBy(x => x.Timestamp).ToList();

            bool result =
                sorted
                .Select((tran, index) =>
                    sorted
                    .Skip(index)
                    .TakeWhile(x =>
                        x.Timestamp <= tran.Timestamp.AddMinutes(10))
                    .Count() > 3)
                .Any(x => x);
            return result;
        }

        //groups transaction by card and return card that have wrong pattern
        public static List<string> FindErrorCards(List<Transaction> transactions)
        {
            return transactions
            .GroupBy(x => x.CardNumber)
            .Where(group => IsSuspicious(group.ToList()))
            .Select(group => group.Key)
            .ToList();
        }
    }

    //calculating spending statictics for each mcc
    public static class MerchantAnalyzer
    {
        public static List<Merchant> GetStatistics(List<Transaction> transactions)
        {
            return transactions
             .GroupBy(x => x.MCC)
             .Select(group => new Merchant
             {
                 MCC = group.Key,
                 TotalSpend = group.Sum(x => x.Amount),
                 AvgTransaction = group.Average(x => x.Amount),
                 TransactionCount = group.Count()
             })
           .ToList();
        }
    }
}