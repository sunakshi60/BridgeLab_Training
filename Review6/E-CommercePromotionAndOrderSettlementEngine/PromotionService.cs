
public class PromotionService
{
    public List<Promotion> promotions;
    public PromotionService(List<Promotion> promotions)
    {
        this.promotions = promotions;
    }

    public PricedOrder CalculateOrder(Order order)
    {
        if (order.Amount <= 0)
        {
            throw new OrderException("Amount must be positive.");
        }

        Promotion foundPromotion = null;
        foreach (Promotion promotion in promotions)
        {
            if (promotion.Code == order.PromoCode)
            {
                foundPromotion = promotion;
                break;
            }
        }

        if (foundPromotion == null)
        {
            throw new InvalidPromoCodeException("Promo code does not exist: " + order.PromoCode);
        }

        if (foundPromotion.Expired)
        {
            throw new InvalidPromoCodeException("Promo code is expired: " + order.PromoCode);
        }

        if (order.Amount < foundPromotion.MinOrder)
        {
            throw new MinimumOrderNotMetException("Minimum order amount is " + foundPromotion.MinOrder);
        }

        decimal discount = order.Amount * foundPromotion.Percent / 100;
        decimal finalAmount = order.Amount - discount;

        PricedOrder pricedOrder = new PricedOrder();

        pricedOrder.OrderId = order.OrderId;
        pricedOrder.Customer = order.Customer;
        pricedOrder.Amount = order.Amount;
        pricedOrder.PromoCode = order.PromoCode;
        pricedOrder.Discount = discount;
        pricedOrder.FinalAmount = finalAmount;

        return pricedOrder;
    }
}