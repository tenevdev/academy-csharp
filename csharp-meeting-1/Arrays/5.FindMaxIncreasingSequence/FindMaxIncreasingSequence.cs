using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSubarray
{
    class FindMaxIncreasingSequence
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

            int maxCount = 0, maxLastIndex = 0;
            int currentCount = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    currentCount += 1;
                }
                else
                {
                    if (currentCount > maxCount)
                    {
                        maxCount = currentCount;
                        maxLastIndex = i - 1;

                    }

                    currentCount = 1;
                }
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                maxLastIndex = array.Length - 1;
            }


            Console.Write("{ ");
            for (int i = maxLastIndex - maxCount + 1; i <= maxLastIndex; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("}");
        }
    }
}

