using NUnit.Framework;

public class BinaryTests
{
    [Test]
    public void BinaryRoundTripTest()
    {
        PricedOrder original = new PricedOrder();

        original.OrderId = "O1";
        original.Customer = "Sneha";
        original.Amount = 2500;
        original.PromoCode = "SAVE10";
        original.Discount = 250;
        original.FinalAmount = 2250;

        BinaryHandler handler = new BinaryHandler();
        PricedOrder decoded = handler.WriteAndRead(original);

        bool result = handler.Verify(original,decoded);

        Assert.That(result, Is.True);
    }
}
