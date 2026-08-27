public class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance) => balance = initialBalance;

    public void Deposit(double amount)
    {
        if (amount > 0)
            balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount > balance)
        {
            throw new InsufficientFundsException(
                "Insufficient funds for withdrawal",
                amount - balance);
        }
        balance -= amount;
    }

    public double GetBalance() => balance;
}