public class Order
{
    public string OrderId { get; set; }
    public string Customer { get; set; }
    public decimal Amount { get; set; }
    public string PromoCode { get; set; }
}

public class Promotion
{
    public string Code { get; set; }
    public decimal Percent { get; set; }
    public decimal MinOrder { get; set; }
    public bool Expired { get; set; }
}

public class PricedOrder
{
    public string OrderId { get; set; }
    public string Customer { get; set; }
    public decimal Amount { get; set; }
    public string PromoCode { get; set; }
    public decimal Discount { get; set; }
    public decimal FinalAmount { get; set; }
}

public class OrderSummary
{
    public int TotalOrders { get; set; }
    public int SuccessfulOrders { get; set; }
    public int RejectedOrders { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TotalDiscount { get; set; }
    public decimal TotalFinalAmount { get; set; }
}

public class PromotionData
{
    public List<Promotion> PromoCodes { get; set; }
}

public class ProcessingResult
{
    public int TotalOrders { get; set; }
    public List<PricedOrder> SuccessfulOrders { get; set; }
    public List<string> Rejections { get; set; }
}