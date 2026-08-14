using System;

namespace SortingAlgorithms
{
    public class SelectionSort
    {
        public static void Sort(int[] scores)
        {
            for (int i = 0; i < scores.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < scores.Length; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }
    }
}