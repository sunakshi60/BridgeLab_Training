using System;
using System.IO;

public class LargeCsvReader
{
    public static void Run()
    {
        string filepath = "LargeStudents.csv";
        int batchSize = 100;
        int processedRecords = 0;
        using (StreamReader reader = new StreamReader(filepath))
        {
            reader.ReadLine();
            while (!reader.EndOfStream)
            {
                int linesProcessedInBatch = 0;
                while (linesProcessedInBatch < batchSize &&
                       !reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    linesProcessedInBatch++;
                    processedRecords++;
                }
                Console.WriteLine($"Records processed: {processedRecords}");
            }
        }
        Console.WriteLine("Finished processing CSV file.");
    }
}