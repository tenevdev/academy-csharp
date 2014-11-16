﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LongestSequence
{
    class LongestSequence
    {
        static string FindLongestSequence(string[,] m)
        {
            int result = 0;
            int max = 0;
            int currRow = 0;
            int currCol = 0;
            int currDiag = 0;
            int temp = 0;
            string maxStr = "";
            for (int rows = 0; rows < m.GetLength(0); rows++)
            {
                for (int cols = 0; cols < m.GetLength(1); cols++)
                {
                    string curr = m[rows, cols];
                    currRow = FindStreak(m, rows, cols, 0);
                    currDiag = FindStreak(m, rows, cols, 1);
                    currCol = FindStreak(m, rows, cols, 2);
                    temp = Math.Max(Math.Max(currRow, currCol), currDiag);
                    if (temp > max)
                    {
                        max = temp;
                        maxStr = curr;
                    }
                }
                if (max == m.GetLength(0))
                {
                    return FormResult(max, maxStr);
                }
            }
            return FormResult(max, maxStr);
        }
        static string FormResult(int n, string str)
        {
            string res = "";
            for (int i = 0; i < n; i++)
            {
                res += str + ", ";
            }
            res = res.Substring(0, res.Length - 2);
            return res;
        }
        static int FindStreak(string[,] m, int startRow, int startCol, int direction)
        {
            int count = -1;
            //in a row
            if (direction == 0)
            {
                count = 1;
                for (int i = startCol + 1; i < m.GetLength(1); i++)
                {
                    if (m[startRow, i] == m[startRow, startCol])
                    {
                        count++;
                    }
                }
            }
            //in a diagonal
            else if (direction == 1)
            {
                count = 1;
                int diagonalSize = (m.GetLength(0) < m.GetLength(1)) ? m.GetLength(0) : m.GetLength(1);
                for (int i = startCol + 1; i < diagonalSize; i++)
                {
                    if (m[i, i] == m[startRow, startCol])
                    {
                        count++;
                    }
                }
            }
            //in a column
            else if (direction == 2)
            {
                count = 1;
                for (int rows = startRow + 1; rows < m.GetLength(0); rows++)
                {
                    if (m[rows, startCol] == m[startRow, startCol])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.Write("Input rows n (n > 2): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input columns m (m > 2): ");
            int m = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, m];
            string[] input;
            Console.WriteLine("Input elements row by row ({0} on each row)", m);
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            string result = FindLongestSequence(matrix);
            Console.WriteLine(result);
        }
    }
}
