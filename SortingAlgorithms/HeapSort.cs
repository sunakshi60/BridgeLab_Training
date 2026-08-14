using System;

namespace SortingAlgorithms
{
    public class HeapSort
    {
        public static void Sort(int[] salaries)
        {
            int n = salaries.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(salaries, n, i);
            }
            for (int i = n - 1; i > 0; i--)
            {
                int temp = salaries[0];
                salaries[0] = salaries[i];
                salaries[i] = temp;
                Heapify(salaries, i, 0);
            }
        }

        private static void Heapify(int[] salaries, int heapSize, int rootIndex)
        {
            int largest = rootIndex;
            int leftChild = 2 * rootIndex + 1;
            int rightChild = 2 * rootIndex + 2;
            if (leftChild < heapSize &&
                salaries[leftChild] > salaries[largest])
            {
                largest = leftChild;
            }
            if (rightChild < heapSize &&
                salaries[rightChild] > salaries[largest])
            {
                largest = rightChild;
            }
            if (largest != rootIndex)
            {
                int temp = salaries[rootIndex];
                salaries[rootIndex] = salaries[largest];
                salaries[largest] = temp;
                Heapify(salaries, heapSize, largest);
            }
        }
    }
}