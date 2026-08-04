using System;

namespace PracticeProblems
{
    class BankAccount
    {
        private int AccountNumber;
        private double Balance;

        public BankAccount(int acc,double bal)
        {
            AccountNumber = acc;
            Balance = bal;
        }

        public virtual void DisplayAccountType()
        {
            Console.WriteLine("Bank Account");
            Console.WriteLine($"Account Number : {AccountNumber}");
            Console.WriteLine($"Balance : {Balance}");
        }
    }
    
    class SavingsAccount : BankAccount
    {
        private double InterestRate;

        public SavingsAccount(int acc, double bal, double interest) : base(acc, bal)
        {
            InterestRate = interest;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("==== Savings Account ====");
            base.DisplayAccountType();
            Console.WriteLine($"Interest Rate : {InterestRate} ");
        }
    }

    class CheckingAccount : BankAccount
    {
        private double WithdrawalLimit;

        public CheckingAccount(int accountNumber, double balance, double withdrawalLimit) : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("===== Checking Account =====");
            base.DisplayAccountType();
            Console.WriteLine($"Withdrawal Limit : {WithdrawalLimit} Rupees");
        }
    }

    class FixedDepositAccount : BankAccount
    {
        private int DepositPeriod;

        public FixedDepositAccount(int accountNumber, double balance, int depositPeriod)
            : base(accountNumber, balance)
        {
            DepositPeriod = depositPeriod;
        }

        public override void DisplayAccountType()
        {
            Console.WriteLine("===== Fixed Deposit Account =====");
            base.DisplayAccountType();
            Console.WriteLine($"Deposit Period : {DepositPeriod} Years");
        }
    }
}