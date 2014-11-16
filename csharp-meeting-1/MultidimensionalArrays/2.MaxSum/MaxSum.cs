using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.MaxSum
{
    class MaxSum
    {
        static void Main(string[] args)
        {
            Console.Write("Input rows n (n > 2): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input columns m (m > 2): ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];
            string[] input;
            Console.WriteLine("Input elements row by row ({0} on each row)", m);
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(input[j]);
                }
            }

            int[] coords = new int[2];
            int currentSum = 0;
            int columnMaxSum = 0;
            int maxSum = 0;
            int startingRowIndex = 0;
            int startingColIndex = 0;

            for (int rows = 0; rows <= matrix.GetLength(0) - 3; rows++)
            {
                for (int cols = 0; cols <= matrix.GetLength(1) - 3; cols++)
                {
                    currentSum += matrix[rows, cols] + matrix[rows, cols + 1] + matrix[rows, cols + 1] +
                       matrix[rows + 1, cols] + matrix[rows + 1, cols + 1] + matrix[rows + 1, cols + 2] +
                       matrix[rows + 2, cols] + matrix[rows + 2, cols + 1] + matrix[rows + 2, cols + 2];
                    if (currentSum > columnMaxSum)
                    {
                        columnMaxSum = currentSum;
                        startingColIndex = cols;
                    }
                    currentSum = 0;
                }
                if (columnMaxSum > maxSum)
                {
                    maxSum = columnMaxSum;
                    startingRowIndex = rows;
                }
            }
            coords[0] = startingRowIndex;
            coords[1] = startingColIndex;

            Console.WriteLine();
            for (int i = coords[0]; i < coords[0] + 3; i++)
            {
                for (int j = coords[1]; j < coords[1] + 3; j++)
                {
                    Console.Write("{0, -3}", matrix[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Sum = {0}", maxSum);
        }
    }
}
