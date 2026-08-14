using System;

namespace SortingAlgorithms
{
    public class QuickSort
    {
        public static void Sort(double[] prices)
        {
            QuickSortArray(prices, 0, prices.Length - 1);
        }
        private static void QuickSortArray(double[] prices,int low,int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(prices, low, high);
                QuickSortArray(prices, low, pivotIndex - 1);
                QuickSortArray(prices, pivotIndex + 1, high);
            }
        }

        private static int Partition(double[] prices,int low,int high)
        {
            double pivot = prices[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (prices[j] <= pivot)
                {
                    i++;
                    double temp = prices[i];
                    prices[i] = prices[j];
                    prices[j] = temp;
                }
            }
            double pivotTemp = prices[i + 1];
            prices[i + 1] = prices[high];
            prices[high] = pivotTemp;
            return i + 1;
        }
    }
}