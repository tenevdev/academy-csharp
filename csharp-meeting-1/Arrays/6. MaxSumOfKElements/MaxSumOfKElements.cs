using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.MaxSumOfKElements
{
    class MaxSumOfKElements
    {
        static void Main(string[] args)
        {
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            Console.Write("Enter n:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] array = new int[n];

            if (k > n)
            {
                Console.WriteLine("Invalid input");
                return;
            }
            Console.WriteLine("Enter array:");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array);

            for (int i = array.Length - 1; i > array.Length - k - 1; i--)
            {
                sum += array[i];
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}