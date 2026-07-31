using System;

namespace AccessModifiersQues
{
    class BankAccount
    {
        public string accountNumber;
        protected string accountHolder;
        private double balance;

        public BankAccount(string accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
    class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountNumber, string accountHolder, double balance)
            : base(accountNumber, accountHolder, balance)
        {
        }
        public void Display()
        {
            Console.WriteLine("Account Number : " + accountNumber);
            Console.WriteLine("Account Holder : " + accountHolder);
            Console.WriteLine("Balance        : " + GetBalance());
        }
    }
}