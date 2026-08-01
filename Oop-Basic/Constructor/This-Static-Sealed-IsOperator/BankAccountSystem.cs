using System;

namespace This_Static_Sealed_IsOperator
{
    class BankAccount
    {
        static string bankName = "State bank of India";
        static int totalAccounts = 0;
        public readonly int accountNumber;
        string accountHolderName;

        public BankAccount(int accountNumber, string accountHolderName)
        {
            this.accountNumber = accountNumber;
            this.accountHolderName = accountHolderName;

            totalAccounts++;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("\nBank Name      : " + bankName);
            Console.WriteLine("Account Number : " + accountNumber);
            Console.WriteLine("Account Holder : " + accountHolderName);
        }
        public static void GetTotalAccounts()
        {
            Console.WriteLine("\nTotal Accounts Created : " + totalAccounts);
        }
    }
}