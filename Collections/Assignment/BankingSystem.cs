using System;
using System.Collections.Generic;

public class WithdrawalRequest
{
    public int AccountId { get; set; }
    public double Amount { get; set; }

    public WithdrawalRequest(int accountId,double amount)
    {
        AccountId = accountId;
        Amount = amount;
    }
}

public class BankingSystem
{
    private Dictionary<int, double> accounts =new Dictionary<int, double>();

    private Queue<WithdrawalRequest> withdrawals = new Queue<WithdrawalRequest>();

    public void AddAccount(int accountId, double balance)
    {
        accounts[accountId] = balance;
    }

    public void AddWithdrawalRequest(int accountId, double amount)
    {
        withdrawals.Enqueue(new WithdrawalRequest(accountId, amount));
    }

    public void ProcessWithdrawals()
    {
        Console.WriteLine("\nProcessing Withdrawals:");

        while (withdrawals.Count > 0)
        {
            WithdrawalRequest request = withdrawals.Dequeue();

            if (accounts.ContainsKey(request.AccountId) &&
                accounts[request.AccountId] >= request.Amount)
            {
                accounts[request.AccountId] -=request.Amount;

                Console.WriteLine(
                    $"Account {request.AccountId}: " +
                    $"Withdrawal {request.Amount} successful");
            }
            else
            {
                Console.WriteLine(
                    $"Account {request.AccountId}: " +
                    $"Withdrawal failed");
            }
        }
    }

    public void DisplayAccountsByBalance()
    {
        SortedDictionary<double, List<int>> sorted =new SortedDictionary<double, List<int>>();
        foreach (var account in accounts)
        {
            if (!sorted.ContainsKey(account.Value))
            {
                sorted[account.Value] =
                    new List<int>();
            }
            sorted[account.Value].Add(account.Key);
        }

        Console.WriteLine("\nAccounts Sorted By Balance:");
        foreach (var item in sorted)
        {
            foreach (int accountId in item.Value)
            {
                Console.WriteLine(
                    $"Account {accountId}: {item.Key}");
            }
        }
    }
}