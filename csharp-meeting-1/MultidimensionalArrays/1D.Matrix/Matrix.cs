using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1D.Matrix
{
    class Matrix
    {
        static void Spiral(int n, int topLeft = 1, int level = 0)
        {
            int newTopLeft = FillFrame(n, topLeft, level);
            if (n < 3)
            {
                return;
            }
            else
            {
                Spiral(n - 2, newTopLeft, ++level);
            }
        }

        private static int FillFrame(int n, int topLeft, int level)
        {
            int bottomRight = (n - 1) * 2 + topLeft;
            int diagonalSum = bottomRight * 2;

            for (int i = level; i < n + level; i++)
            {
                matrix[level, i] = topLeft + i - level;
            }

            if (n != 1)
            {
                for (int i = level + 1; i < n + level - 1; i++)
                {
                    matrix[i, level] = diagonalSum - topLeft - i + level;
                    matrix[i, n + level - 1] = topLeft + i + n - 1 - level;
                }

                for (int i = level; i < n + level; i++)
                {
                    matrix[n + level - 1, i] = diagonalSum - i - topLeft - n + 1 + level;
                }
            }

            return diagonalSum - topLeft;
        }

        private static void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    PrintNumber(matrix[j, i]);
                }
                Console.WriteLine();
            }
        }

        static void PrintNumber(int number)
        {
            Console.Write("{0, -4}", number);
        }

        private static int[,] matrix;
        static void Main(string[] args)
        {
            Console.SetWindowSize(100, 50);
            
            Console.Write("Input n: ");
            int n = int.Parse(Console.ReadLine());

            matrix = new int[n,n];

            Spiral(n);

            PrintMatrix();
        }
    }
}
