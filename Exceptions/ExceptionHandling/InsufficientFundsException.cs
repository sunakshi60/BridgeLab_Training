public class InsufficientFundsException : Exception
{
    public double Amount { get; }   // extra contextual data beyond just a message

    public InsufficientFundsException() : base() { }

    public InsufficientFundsException(string message) : base(message) { }

    public InsufficientFundsException(string message, double amount)
        : base(message)
    {
        Amount = amount;
    }

    public InsufficientFundsException(string message, Exception innerException)
        : base(message, innerException) { }
}