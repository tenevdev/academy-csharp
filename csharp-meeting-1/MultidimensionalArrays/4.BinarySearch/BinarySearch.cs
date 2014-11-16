using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.Write("Input k: ");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Input array: ");
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);
            int index;

            do
            {
                index = Array.BinarySearch(array, k--);
            }
            while (index < 0);

            Console.WriteLine(k+1);
        }
    }
}
