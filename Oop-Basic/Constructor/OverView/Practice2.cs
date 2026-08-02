using System;

namespace OverView
{
    public class BankAccount{
        //working of encapsulation to see how we wrapping data (fields) and methods together.
        private double balance;
        public double Balance
        {
            get { return balance; }
            private set { balance = value; }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Invalid withdrawal");
        }
    }
}