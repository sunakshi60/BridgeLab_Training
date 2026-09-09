using NUnit.Framework;

public class PromotionTests
{
    private PromotionService GetTest()
    {
        List<Promotion> promotions = new List<Promotion>();
        promotions.Add(new Promotion
            {
                Code = "SAVE10",
                Percent = 10,
                MinOrder = 1000,
                Expired = false
            });

        promotions.Add(new Promotion
            {
                Code = "EXPIRED5",
                Percent = 5,
                MinOrder = 500,
                Expired = true
            });

        return new PromotionService(promotions);
    }

    [Test]
    public void ValidDiscountTest()
    {
        Order order = new Order();
        order.OrderId = "O1";
        order.Customer = "Sneha";
        order.Amount = 2500;
        order.PromoCode = "SAVE10";
        PricedOrder result =GetTest().CalculateOrder(order);
        Assert.That(result.Discount,Is.EqualTo(250));
        Assert.That(result.FinalAmount,Is.EqualTo(2250));
    }

    [Test]
    public void ExpiredPromoTest()
    {
        Order order = new Order();
        order.OrderId = "O4";
        order.Customer = "Rahul";
        order.Amount = 1200;
        order.PromoCode = "EXPIRED5";
        Assert.Throws<InvalidPromoCodeException>( () => GetTest().CalculateOrder(order));
    }

    [Test]
    public void UnknownPromoTest()
    {
        Order order = new Order();

        order.OrderId = "O6";
        order.Amount = 800;
        order.PromoCode = "BOGUS";

        Assert.Throws<InvalidPromoCodeException>(
            () => GetTest().CalculateOrder(order));
    }

    [Test]
    public void MinimumOrderFailureTest()
    {
        Order order = new Order();
        order.OrderId = "O2";
        order.Customer = "Amit";
        order.Amount = 500;
        order.PromoCode = "SAVE10";
        Assert.Throws<MinimumOrderNotMetException>(() => GetTest().CalculateOrder(order));
    }
    [Test]
    public void PositiveAmountTest()
    {
        Order order = new Order();
        order.OrderId = "O1";
        order.Amount = 0;
        order.PromoCode = "SAVE10";
        Assert.Throws<OrderException>(() => GetTest().CalculateOrder(order));
    }

}