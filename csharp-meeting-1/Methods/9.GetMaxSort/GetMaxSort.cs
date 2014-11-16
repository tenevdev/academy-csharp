using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.GetMaxSort
{
    class GetMaxSort
    {
        static int GetMax(int startIndex, int[] array)
        {
            int max = int.MinValue;
            int maxIndex = -1;
            for (int i = startIndex; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        static void SortDesc(int[] array)
        {
            int temp, index;

            for (int i = 0; i < array.Length; i++)
            {
                index = GetMax(i, array);
                temp = array[index];
                array[index] = array[i];
                array[i] = temp;
            }
        }
        static void SortAsc(int[] array)
        {
            SortDesc(array);
            Array.Reverse(array);
        }
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            Console.WriteLine("Input array: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            SortDesc(a);

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.WriteLine();

            SortAsc(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0} ", a[i]);
            }

        }
    }
}
