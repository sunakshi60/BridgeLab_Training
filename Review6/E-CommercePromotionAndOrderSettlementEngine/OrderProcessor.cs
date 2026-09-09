public class OrderProcessor
{
    public PromotionService promotionService;
    public BinaryHandler binaryHandler;

    public OrderProcessor(PromotionService promotionService, BinaryHandler binaryHandler)
    {
        this.promotionService = promotionService;
        this.binaryHandler = binaryHandler;
    }

    public ProcessingResult ProcessOrders(List<Order> orders)
    {
        List<PricedOrder> successfulOrders =new List<PricedOrder>();
        List<string> rejections = new List<string>();
        HashSet<string> orderIds = new HashSet<string>();

        foreach (Order order in orders)
        {
            try
            {
                if (orderIds.Contains(order.OrderId))
                {
                    throw new DuplicateOrderException("Duplicate OrderId: " + order.OrderId);
                }

                orderIds.Add(order.OrderId);

                PricedOrder pricedOrder = promotionService.CalculateOrder(order);
                PricedOrder decodedOrder = binaryHandler.WriteAndRead(pricedOrder);

                bool verified = binaryHandler.Verify(
                        pricedOrder,
                        decodedOrder);

                if (!verified)
                {
                    throw new OrderException("Binary verification failed.");
                }
                successfulOrders.Add(pricedOrder);
            }
            catch (OrderException ex)
            {
                rejections.Add(order.OrderId + ": " + ex.Message);
            }
        }

        ProcessingResult result = new ProcessingResult();
        result.TotalOrders = orders.Count;
        result.SuccessfulOrders = successfulOrders;
        result.Rejections = rejections;
        return result;
    }
}