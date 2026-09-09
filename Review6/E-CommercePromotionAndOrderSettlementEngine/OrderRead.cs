using System.Globalization;

public class OrderRead
{
    public List<Order> ReadOrders(string filePath)
    {
        List<Order> orders = new List<Order>();

        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        using (StreamReader reader = new StreamReader(fileStream))
        {
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] data = line.Split(',');
                if (data.Length != 4)
                {
                    Console.WriteLine("Invalid CSV row: " + line);
                    continue;
                }

                decimal amount;
                bool validAmount = decimal.TryParse(
                        data[2],
                        NumberStyles.Number,
                        CultureInfo.InvariantCulture,
                        out amount);

                if (!validAmount)
                {
                    Console.WriteLine("Invalid amount for OrderId: "+ data[0]);
                    continue;
                }

                Order order = new Order();
                order.OrderId = data[0];
                order.Customer = data[1];
                order.Amount = amount;
                order.PromoCode = data[3];
                orders.Add(order);
            }
        }
        return orders;
    }
}