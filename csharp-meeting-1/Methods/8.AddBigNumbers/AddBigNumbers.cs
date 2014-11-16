using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _8.AddBigNumbers
{
    class AddBigNumbers
    {
        static BigInteger Add(int[] a, int[] b)
        {
            BigInteger number = 0;
            int n = a.Length;
            int digit, left = 0;
            for (int i = 0; i < n; i++)
            {
                digit = (a[i] + b[i]) % 10;
                left = (a[i] + b[i]) / 10;
                number += (int)Math.Pow(10, i) * (digit + left);
            }

            return number;
        }
        static void Main(string[] args)
        {
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            Console.WriteLine("Input array: ");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            int[] b = new int[n];
            Console.WriteLine("Input array: ");
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(Add(a, b));
        }
    }
}
