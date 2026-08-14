using System;

namespace SortingAlgorithms
{
    public class MergeSort
    {
        public static void Sort(double[] prices)
        {
            if (prices.Length <= 1)
            {
                return;
            }
            double[] temp = new double[prices.Length];
            MergeSortArray(prices, temp, 0, prices.Length - 1);
        }

       private static void MergeSortArray(double[] prices, double[] temp,int left,int right)
        {
            if (left >= right)
            {
                return;
            }

            int middle = left + (right - left) / 2;
            MergeSortArray(prices, temp, left, middle);
            MergeSortArray(prices, temp, middle + 1, right);
            Merge(prices, temp, left, middle, right);
        }

        private static void Merge(double[] prices, double[] temp,int left,int middle,int right)
        {
            int i = left;
            int j = middle + 1;
            int k = left;
            while (i <= middle && j <= right)
            {
                if (prices[i] <= prices[j])
                {
                    temp[k] = prices[i];
                    i++;
                }
                else
                {
                    temp[k] = prices[j];
                    j++;
                }
                k++;
            }
            while (i <= middle)
            {
                temp[k] = prices[i];
                i++;
                k++;
            }
            while (j <= right)
            {
                temp[k] = prices[j];
                j++;
                k++;
            }
            for (int index = left; index <= right; index++)
            {
                prices[index] = temp[index];
            }
        }
    }
}