using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class QuickSort
    {
        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;
            for (int j = left; j <= right - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            int temp2 = array[i + 1];
            array[i + 1] = array[right];
            array[right] = temp2;
            return i + 1;
        }

        public static void Sort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                Sort(array, left, pivotIndex - 1);
                Sort(array, pivotIndex + 1, right);
            }
        }
    }
}
