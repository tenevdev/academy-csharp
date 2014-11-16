using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.MostCommonValue
{
    class MostCommonValue
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


            Array.Sort(array);
            int current = 0, max = 0, index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i - 1])
                {
                    if (current > max)
                    {
                        max = current;
                        index = i - 1;
                    }
                    current = 1;
                }
                else
                {
                    current += 1;
                }
            }


			Console.WriteLine("{0} ({1} times)", array[index], max);
		}
	}
}
