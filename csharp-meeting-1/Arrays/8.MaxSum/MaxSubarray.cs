using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSubarray
{
    class MaxSubarray
	{
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

            int max = array[0], currentMax = array[0], index = 0; ;

            for (int i = 1; i < array.Length; i++)
            {
                currentMax = Math.Max(0, currentMax + array[i]);
                if (currentMax > max)
                {
                    max = currentMax;
                    index = i;
                }
            }

            int sum = 0;
            while(sum != max)
            {
                sum += array[index];
                Console.Write("{0} + ", array[index]);
                index -= 1;
            }
            Console.SetCursorPosition(Console.CursorLeft - 2 > 0 ? Console.CursorLeft - 2 : 0, Console.CursorTop);
            Console.WriteLine("= {0}", max);
		}
	}
}

