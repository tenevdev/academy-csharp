using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BiggerThanNeighboursMethod
{
    class BiggerThanNeighboursMethod
    {
        static bool CheckNeighbours(int index, int[] array)
        {
            if (index < 1 || index >= array.Length)
            {
                return false;
            }
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                return true;
            }
            return false;
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

            Console.WriteLine("Input search index: ");
            int index = int.Parse(Console.ReadLine());

            bool res = CheckNeighbours(index, array);
            Console.WriteLine(res.ToString());
        }
    }
}
