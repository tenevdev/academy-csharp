using System;
using System.Collections.Generic;
using System.Text;

namespace _14.QuickSort
{
    class QuickSort
    {
        /// <summary>
        /// Reorder the array so that all elements with values less than the pivot come before the pivot,
        /// while all elements with values greater than the pivot come after it.
        /// </summary>
        /// <param name="array">Base array</param>
        /// <param name="start">Partition start index</param>
        /// <param name="end">Partition end index</param>
        /// <returns>Index of pivot</returns>
        static public int Partition(int[] array, int start, int end)
        {
            // Choose pivot index
            int pivotIndex = start + (end - start) / 2;
            int pivot = array[pivotIndex];

            int temp = array[end];
            array[end] = array[pivotIndex];
            array[pivotIndex] = temp;

            int storeIndex = start;
            for (int i = start; i < end; i++)
            {
                if (array[i] < pivot)
                {
                    temp = array[i];
                    array[i] = array[storeIndex];
                    array[storeIndex] = temp;
                    storeIndex++;
                }
            }
            temp = array[storeIndex];
            array[storeIndex] = array[end];
            array[end] = temp;

            return storeIndex;
        }

        /// <summary>
        /// Sort array using recursive quick sort
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        /// <param name="start">Starting index</param>
        /// <param name="end">Ending index</param>
        static public void Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int pivot = Partition(array, start, end);
                Sort(array, start, pivot - 1);
                Sort(array, pivot + 1, end);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter array length:");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Sort(array, 0, array.Length - 1);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}