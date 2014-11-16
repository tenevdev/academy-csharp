using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.MergeSort
{
    class MergeSort
    {
        /// <summary>
        /// Merge two parts of an array
        /// </summary>
        /// <param name="array">Base array</param>
        /// <param name="start">Starting index of first part</param>
        /// <param name="mid">Middle</param>
        /// <param name="end">Ending index of second part</param>
        static void Merge(int[] array, int start, int mid, int end)
        {
            int[] temp = new int[end - start + 1];
            int first = start, second = mid + 1, current = 0;

            while (first <= mid && second <= end)
            {
                if (array[first] < array[second])
                {
                    temp[current] = array[first];
                    first++;
                }
                else
                {
                    temp[current] = array[second];
                    second++;
                }
                current++;
            }

            while (first <= mid)
            {
                temp[current] = array[first];
                current++;
                first++;
            }
            while (second <= end)
            {
                temp[current] = array[second];
                current++;
                second++;
            }

            current = 0;
            first = start;

            while (current < temp.Length && first <= end)
            {
                array[first] = temp[current];
                current++;
                first++;
            }
        }

        /// <summary>
        /// Sort array using recursive merge
        /// </summary>
        /// <param name="array">The array to be sorted</param>
        /// <param name="start">Starting index</param>
        /// <param name="end">Ending index</param>
        static void Sort(int[] array, int start, int end)
        {
            if (start < end)
            {
                int mid = (end + start) / 2;
                Sort(array, start, mid);
                Sort(array, mid + 1, end);
                Merge(array, start, mid, end);
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

        }
    }
}
