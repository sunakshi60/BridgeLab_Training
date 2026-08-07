using System;
using System.Collections.Generic;
using System.Text;

namespace NUnit_Testing
{
    public class BankAccount
    {
        private double balance;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient Balance");
            }
            balance -= amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
