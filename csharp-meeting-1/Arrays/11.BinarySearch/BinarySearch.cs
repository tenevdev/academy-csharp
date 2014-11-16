using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BinarySearch
{
    class BinarySearch
	{
		static void Main(string[] args)
        {
            Console.Write("Enter array length:");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            Console.WriteLine("Enter array (will be sorted if it isn\'t):");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter search value: ");
			int search = int.Parse (Console.ReadLine());

			Array.Sort (array);

            int mid, lowBound = 0, highBound = array.Length - 1, result = -1;
            while (lowBound <= highBound)
            {
                mid = (lowBound + highBound) / 2;
                if (array[mid] < search)
                {
                    lowBound = mid + 1;
                    continue;
                }
                else if (array[mid] > search)
                {
                    highBound = mid - 1;
                    continue;
                }
                else
                {
                    result = mid;
                    break;
                }
            }

			Console.WriteLine("The index is {0}", result);
		}
	}
}
