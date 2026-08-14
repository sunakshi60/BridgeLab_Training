using System;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public static void Sort(int[] employeeIds)
        {
            for (int i = 1; i < employeeIds.Length; i++)
            {
                int key = employeeIds[i];
                int j = i - 1;
                while (j >= 0 && employeeIds[j] > key)
                {
                    employeeIds[j + 1] = employeeIds[j];
                    j--;
                }
                employeeIds[j + 1] = key;
            }
        }
    }
}