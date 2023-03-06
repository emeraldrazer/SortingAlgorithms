using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class HeapSort
    {
        public static void Sort(int[] array)
        {
            int n = array.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                Heapify(array, i, 0);
            }
        }

        public static void Heapify(int[] array, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && array[left] > array[largest])
            {
                largest = left;
            }

            if (right < n && array[right] > array[largest])
            {
                largest = right;
            }

            if (largest != i)
            {
                int temp = array[i];
                array[i] = array[largest];
                array[largest] = temp;

                Heapify(array, n, largest);
            }
        }
    }
}
