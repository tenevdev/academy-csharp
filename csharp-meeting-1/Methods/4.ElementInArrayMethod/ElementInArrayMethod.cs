using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.ElementInArrayMethod
{
    class ElementInArrayMethod
    {
        static int ElementCount(int element, int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    count++;
                }
            }
            return count;
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

            Console.WriteLine("Input search element: ");
            int el = int.Parse(Console.ReadLine());

            int count = ElementCount(el, array);
            Console.WriteLine("The element {0} appears {1} times", el, count);
        }
    }
}
