using Newtonsoft.Json;

public class PromotionLoad
{
    public List<Promotion> LoadPromotions(string filePath)
    {
        FileStream fileStream = new FileStream(filePath, FileMode.Open);
        StreamReader reader = new StreamReader(fileStream);
        string json = reader.ReadToEnd();

        reader.Close();
        fileStream.Close();

        PromotionData data = JsonConvert.DeserializeObject<PromotionData>(json);

        return data.PromoCodes;
    }
}