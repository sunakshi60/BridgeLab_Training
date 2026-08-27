class Program
{
    static void Main()
    {
        BankAccount account = new BankAccount(100.0);

        try
        {
            Console.WriteLine("Depositing $50...");
            account.Deposit(50.0);
            Console.WriteLine("New balance: $" + account.GetBalance());

            Console.WriteLine("Withdrawing $200...");
            account.Withdraw(200.0);
        }
        catch (InsufficientFundsException e)
        {
            Console.WriteLine($"Exception: {e.Message}");
            Console.WriteLine($"Shortfall: ${e.Amount}");
        }

        Console.ReadLine();
    }
}