using Newtonsoft.Json;

public class OutputFiles
{
    public void WritePricedOrders(List<PricedOrder> orders)
    {
        using (FileStream fileStream = new FileStream(
                "priced_orders.json",
                FileMode.Create))
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            string json = JsonConvert.SerializeObject(
                    orders,
                    Formatting.Indented);

            writer.Write(json);
        }
    }

    public void WriteSummary(OrderSummary summary)
    {
        using (FileStream fileStream = new FileStream(
                "order_summary.json",
                FileMode.Create))
        using (StreamWriter writer = new StreamWriter(fileStream))
        {
            string json = JsonConvert.SerializeObject(
                    summary,
                    Formatting.Indented);

            writer.Write(json);
        }
    }

    public void WriteRejections(List<string> rejections)
    {
        using (FileStream fileStream = new FileStream(
                "rejections.log",
                FileMode.Create))
        using (BufferedStream bufferedStream = new BufferedStream(fileStream))
        using (StreamWriter writer = new StreamWriter(bufferedStream))
        {
            foreach (string rejection in rejections)
            {
                writer.WriteLine(rejection);
            }
        }
    }
}