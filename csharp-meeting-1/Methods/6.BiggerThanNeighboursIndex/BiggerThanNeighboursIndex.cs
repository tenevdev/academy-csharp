using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.BiggerThanNeighboursIndex
{
    class BiggerThanNeighboursIndex
    {
        static int IndexOfBiggerThanNeighbours(int[] array)
        {
            if (array[0] > array[1])
                return 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    return i;
                }
            }
            if (array[array.Length - 1] > array[array.Length - 2])
            {
                return array.Length - 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            Console.WriteLine("Input array: ");
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(IndexOfBiggerThanNeighbours(array));
        }
    }
}
