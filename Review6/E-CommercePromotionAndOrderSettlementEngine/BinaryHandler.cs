using System.Text;

public class BinaryHandler
{
    public PricedOrder WriteAndRead(PricedOrder order)
    {
        MemoryStream memoryStream = new MemoryStream();
        BinaryWriter writer = new BinaryWriter(
                memoryStream,
                Encoding.UTF8,
                true);

        writer.Write(order.OrderId);
        writer.Write(order.Customer);
        writer.Write(order.Amount);
        writer.Write(order.PromoCode);
        writer.Write(order.Discount);
        writer.Write(order.FinalAmount);

        writer.Flush();

        memoryStream.Position = 0;

        BinaryReader reader = new BinaryReader(
                memoryStream,
                Encoding.UTF8,
                true);

        PricedOrder result = new PricedOrder();

        result.OrderId = reader.ReadString();
        result.Customer = reader.ReadString();
        result.Amount = reader.ReadDecimal();
        result.PromoCode = reader.ReadString();
        result.Discount = reader.ReadDecimal();
        result.FinalAmount = reader.ReadDecimal();

        reader.Close();
        writer.Close();
        memoryStream.Close();

        return result;
    }

    public bool Verify(PricedOrder original, PricedOrder decoded)
    {
        if (original.OrderId != decoded.OrderId)
            return false;

        if (original.Customer != decoded.Customer)
            return false;

        if (original.Amount != decoded.Amount)
            return false;

        if (original.PromoCode != decoded.PromoCode)
            return false;

        if (original.Discount != decoded.Discount)
            return false;

        if (original.FinalAmount != decoded.FinalAmount)
            return false;

        return true;
    }
}