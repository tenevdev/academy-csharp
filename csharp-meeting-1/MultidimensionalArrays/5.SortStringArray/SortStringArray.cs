using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SortStringArray
{
    class SortStringArray
    {
        static void Sort(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].Length > array[j].Length)
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());

            string[] array = new string[n];
            string[] input;
            Console.WriteLine("Input elements on one row");
            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                array[i] = input[i];
            }

            Sort(array);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
