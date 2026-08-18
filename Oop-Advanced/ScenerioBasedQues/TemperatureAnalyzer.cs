using System;

namespace ScenerioBasedQues
{
    class TemperatureAnalyzer
    {
        public static void AnalyzeTemperature(float[,] temperature)
        {
            int days = temperature.GetLength(0);
            int hours = temperature.GetLength(1);

            float[] dailyAverage = new float[days];
            float hottestAvg = float.MinValue;
            float coldestAvg = float.MaxValue;

            int hottestDay = 0;
            int coldestDay = 0;

            for (int i = -0; i < days; i++)
            {
                float sum = 0;
                for (int j = 0; j < hours; j++)
                {
                    sum += temperature[i, j];
                }
                dailyAverage[i] = sum / hours;

                if (dailyAverage[i] > hottestAvg)
                {
                    hottestAvg = dailyAverage[i];
                    hottestDay = i;
                }

                if (dailyAverage[i] < coldestAvg)
                {
                    coldestAvg = dailyAverage[i];
                    coldestDay = i;
                }
            }
            Console.WriteLine("Average Temperature Per Day:");

            for (int i = 0; i < days; i++)
            {
                Console.WriteLine($"Day {i + 1}: {dailyAverage[i]:F2}°C");
            }

            Console.WriteLine($"\nHottest Day : Day {hottestDay + 1} ({hottestAvg:F2}°C)");
            Console.WriteLine($"Coldest Day : Day {coldestDay + 1} ({coldestAvg:F2}°C)");
        }
    }
}