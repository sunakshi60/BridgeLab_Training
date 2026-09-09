
public class Program
{
    public static void Main()
    {
        string ordersFile = "orders.csv";
        string promotionsFile = "discounts.json";

        PromotionLoad loader = new PromotionLoad();
        List<Promotion> promotions =loader.LoadPromotions(promotionsFile);
        PromotionService service = new PromotionService(promotions);
        BinaryHandler binaryHandler =new BinaryHandler();

        OrderProcessor processor =new OrderProcessor(
                service,
                binaryHandler);

        OrderRead reader = new OrderRead();
        List<Order> orders = reader.ReadOrders(ordersFile);
        ProcessingResult result = processor.ProcessOrders(orders);

        OrderSummary summary = new OrderSummary();
        summary.TotalOrders = result.TotalOrders;
        summary.SuccessfulOrders = result.SuccessfulOrders.Count;
        summary.RejectedOrders = result.Rejections.Count;
        foreach (PricedOrder order in result.SuccessfulOrders)
        {
            summary.TotalAmount += order.Amount;
            summary.TotalDiscount += order.Discount;
            summary.TotalFinalAmount += order.FinalAmount;
        }

        OutputFiles files = new OutputFiles();
        files.WritePricedOrders(result.SuccessfulOrders);
        files.WriteSummary(summary);
        files.WriteRejections(result.Rejections);

        Console.WriteLine("Processing completed.");
        Console.WriteLine("Total Orders: " + summary.TotalOrders);
        Console.WriteLine("Successful Orders: " + summary.SuccessfulOrders);
        Console.WriteLine("Rejected Orders: " + summary.RejectedOrders);
        Console.WriteLine("Total Amount: " + summary.TotalAmount);
        Console.WriteLine("Total Discount: " + summary.TotalDiscount);
        Console.WriteLine("Final Amount: " + summary.TotalFinalAmount);

        Console.ReadLine();
    }
}