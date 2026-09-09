using Newtonsoft.Json;

public class PromotionLoad
{
    public List<Promotion> LoadPromotions(string filePath)
    {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        {
            using (StreamReader reader = new StreamReader(fileStream))
            {
                string json = reader.ReadToEnd();
                PromotionData data = JsonConvert.DeserializeObject<PromotionData>(json);
                return data.PromoCodes;
            }
        }
    }
}