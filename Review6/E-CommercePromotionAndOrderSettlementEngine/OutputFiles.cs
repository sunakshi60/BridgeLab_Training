using Newtonsoft.Json;

public class OutputFiles
{
    public void WritePricedOrders(List<PricedOrder> orders)
    {
        FileStream fileStream = new FileStream(
                "priced_orders.json",
                FileMode.Create);

        StreamWriter writer = new StreamWriter(fileStream);

        string json = JsonConvert.SerializeObject(
                orders,
                Formatting.Indented);

        writer.Write(json);

        writer.Close();
        fileStream.Close();
    }

    public void WriteSummary(OrderSummary summary)
    {
        FileStream fileStream = new FileStream(
                "order_summary.json",
                FileMode.Create);

        StreamWriter writer = new StreamWriter(fileStream);

        string json = JsonConvert.SerializeObject(
                summary,
                Formatting.Indented);

        writer.Write(json);

        writer.Close();
        fileStream.Close();
    }

    public void WriteRejections(List<string> rejections)
    {
        FileStream fileStream = new FileStream(
                "rejections.log",
                FileMode.Create);

        BufferedStream bufferedStream = new BufferedStream(fileStream);
        StreamWriter writer = new StreamWriter(bufferedStream);

        foreach (string rejection in rejections)
        {
            writer.WriteLine(rejection);
        }

        writer.Close();
        bufferedStream.Close();
        fileStream.Close();
    }
}