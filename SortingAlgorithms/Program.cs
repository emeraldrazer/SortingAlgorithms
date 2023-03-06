using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class Program
    {
        readonly static int[] array1 = { 10, 9, 11, 16, 15, 20, 14, 21, 12, 13, 19, 17, 18 };
        readonly static int[] array2 = { 10, 9, 11, 16, 15, 20, 14, 21, 12, 13, 19, 17, 18 };
        readonly static int[] array3 = { 10, 9, 11, 16, 15, 20, 14, 21, 12, 13, 19, 17, 18 };
        readonly static int[] array4 = { 10, 9, 11, 16, 15, 20, 14, 21, 12, 13, 19, 17, 18 };
        readonly static int[] array5 = { 10, 9, 11, 16, 15, 20, 14, 21, 12, 13, 19, 17, 18 };
        readonly static int[] array6 = { 10, 9, 11, 16, 15, 20, 14, 21, 12, 13, 19, 17, 18 };

        static void Main(string[] args)
        {
            Console.Write($"Original\t\t{string.Join(", ", array1)}");
            
            BubbleSort.Sort(array1);
            InsertionSort.Sort(array2);
            SelectionSort.Sort(array3);
            MergeSort.Sort(array4, 0, array4.Length - 1);
            QuickSort.Sort(array5, 0, array5.Length - 1);
            HeapSort.Sort(array6);

            Console.Write($"\n1. BubbleSort\t\t{string.Join(", ", array1)}");
            Console.Write($"\n2. InsertionSort\t{string.Join(", ", array2)}");
            Console.Write($"\n3. SelectionSort\t{string.Join(", ", array3)}");
            Console.Write($"\n4. MergeSort\t\t{string.Join(", ", array4)}");
            Console.Write($"\n5. QuickSort\t\t{string.Join(", ", array5)}");
            Console.Write($"\n6. HeapSort\t\t{string.Join(", ", array6)}");

            Console.ReadKey();
        }

    }
}
