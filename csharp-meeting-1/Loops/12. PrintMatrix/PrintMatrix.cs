using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.PrintMatrix
{
    class PrintMatrix
    {
        private static int[,] matrix;
        private static int cellSpace;

        static int CalculateCellSpace(int n)
        {
            int maxValue = 2 * n - 1;
            int cellSpace = 1;
            while (maxValue > 0)
            {
                maxValue /= 10;
                cellSpace++;
            }
            return cellSpace;
        }
        static void PrintNumber(int number)
        {
            string numberOutput = number.ToString() + new string(' ', cellSpace - number.ToString().Length + 1);
            Console.Write(numberOutput);
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            cellSpace = CalculateCellSpace(n);

            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j < n + i; j++)
                {
                    PrintNumber(j);
                }
                Console.WriteLine();
            }
           
        }
    }
}
