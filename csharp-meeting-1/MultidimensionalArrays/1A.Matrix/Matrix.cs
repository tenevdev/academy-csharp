using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1A.Matrix
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = n * j + 1 + i;
                    Console.Write("{0, -4} ", n*j + 1 + i);
                }
                Console.WriteLine();
            }
        }
    }
}
