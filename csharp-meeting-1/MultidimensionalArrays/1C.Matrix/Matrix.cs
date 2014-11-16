using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1C.Matrix
{
    class Matrix
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 100;
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            int rows = 0;
            int cols = 0;
            int value = 1;

            for (int i = n - 1; i >= 0; i--)
            {
                rows = i;
                cols = 0;
                while (rows < n && cols < n)
                {
                    matrix[rows++, cols++] = value++;
                }
            }

            for (int j = 1; j < n; j++)
            {
                rows = j;
                cols = 0;
                while (rows < n && cols < n)
                {
                    matrix[cols++, rows++] = value++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, -4}  ", matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
