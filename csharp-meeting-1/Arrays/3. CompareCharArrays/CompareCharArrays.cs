using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            Console.Write("Input array length: ");
            int n = int.Parse(Console.ReadLine());

            char[] first = new char[n];
            char[] second = new char[n];

            Console.WriteLine("Input first array on a single row with spaces");
            string input = Console.ReadLine();
            first = input.Replace(" ", string.Empty).ToCharArray();

            Console.WriteLine("Input second array on a single row with spaces");
            input = Console.ReadLine();
            second = input.Replace(" ", string.Empty).ToCharArray();

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] > second[i])
                {
                    Console.WriteLine("First array > Second array");
                    return;
                }
                else if (first[i] < second[i])
                {
                    Console.WriteLine("First array < Second array");
                    return;
                }
            }
            Console.WriteLine("First array = Second array");
        }
    }
}
