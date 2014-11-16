using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.PrintArray
{
    class PrintArray
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 5;
            }
            foreach (var num in array)
            {
                Console.WriteLine(num);
            }
        }
    }
}
