using System;

namespace PracticeProblems
{
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }
    public class BankAccount
    {
        private double balance;

        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount!");
            }

            if (amount > balance)
            {
                throw new InsufficientFundsException("Insufficient balance!");
            }

            balance -= amount;

            Console.WriteLine(
                $"Withdrawal successful, new balance: {balance}"
            );
        }
    }
}