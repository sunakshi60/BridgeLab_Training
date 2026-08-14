using System;

namespace SortingAlgorithms
{
    public class CountingSort
    {
        public static int[] Sort(int[] ages)
        {
            int minAge = 10;
            int maxAge = 18;
            int range = maxAge - minAge + 1;
            int[] count = new int[range];
            foreach (int age in ages)
            {
                count[age - minAge]++;
            }
            for (int i = 1; i < count.Length; i++)
            {
                count[i] = count[i] + count[i - 1];
            }
            int[] output = new int[ages.Length];
            for (int i = ages.Length - 1; i >= 0; i--)
            {
                int age = ages[i];
                int index = age - minAge;
                output[count[index] - 1] = age;
                count[index]--;
            }
            return output;
        }
    }
}