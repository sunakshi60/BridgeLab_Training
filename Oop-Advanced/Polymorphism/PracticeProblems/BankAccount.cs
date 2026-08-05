using System;

namespace PracticeProblems
{
    interface ILoanable
    {
        void ApplyForLoan();
        double CalculateLoanEligibility();
    }

    abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string HolderName
        {
            get { return holderName; }
            set { holderName = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public BankAccount(string accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited : {amount}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrawn : {amount}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        public abstract double CalculateInterest();
        public void DisplayDetails()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Holder Name    : {HolderName}");
            Console.WriteLine($"Balance        : {Balance}");
        }
    }

    class SavingsAccount : BankAccount, ILoanable
    {
        public SavingsAccount(string accountNumber, string holderName, double balance)
            : base(accountNumber, holderName, balance)
        {

        }

        public override double CalculateInterest()
        {
            return Balance * 0.04;   
        }

        public void ApplyForLoan()
        {
            Console.WriteLine("Loan Application Submitted.");
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 5;
        }
    }
    class CurrentAccount : BankAccount, ILoanable
    {
        public CurrentAccount(string accountNumber, string holderName, double balance)
            : base(accountNumber, holderName, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.02;   
        }

        public void ApplyForLoan()
        {
            Console.WriteLine("Loan Application Submitted.");
        }

        public double CalculateLoanEligibility()
        {
            return Balance * 8;
        }
    }
}
