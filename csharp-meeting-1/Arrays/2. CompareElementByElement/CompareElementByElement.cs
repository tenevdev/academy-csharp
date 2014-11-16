using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.CompareElementByElement
{
    class CompareElementByElement
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length:");
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            Console.WriteLine("Enter first array:");
            for (int i = 0; i < firstArr.Length; i++)
            {
                firstArr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter second array:\n");

            for (int i = 0; i < secondArr.Length; i++)
            {
                secondArr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] > secondArr[i])
                {
                    Console.WriteLine("{0} > {1}", firstArr[i], secondArr[i]);
                }
                else if (firstArr[i] < secondArr[i])
                {
                    Console.WriteLine("{0} < {1}", firstArr[i], secondArr[i]);
                }
                else
                {
                    Console.WriteLine("{0} = {1}", firstArr[i], secondArr[i]);                    
                }
            }
        }
    }
}
