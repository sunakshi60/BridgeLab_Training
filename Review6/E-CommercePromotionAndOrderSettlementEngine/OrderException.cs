public class OrderException : Exception
{
    public OrderException(string message)
        : base(message)
    {
    }
}

public class InvalidPromoCodeException : OrderException
{
    public InvalidPromoCodeException(string message)
        : base(message)
    {
    }
}

public class MinimumOrderNotMetException : OrderException
{
    public MinimumOrderNotMetException(string message)
        : base(message)
    {
    }
}

public class DuplicateOrderException : OrderException
{
    public DuplicateOrderException(string message)
        : base(message)
    {
    }
}