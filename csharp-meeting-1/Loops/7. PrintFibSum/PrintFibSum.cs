using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PrintFibSum
{
    class PrintFibSum
    {

        private static int CalculateFibonacci(int length)
        {
            int prevFib = 0,
            curFib = 1;

            for (int i = 0; i < length; i++)
            {
                int temp = curFib;
                curFib += prevFib;
                prevFib = temp;
            }

            return prevFib;
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger prev = 0, next = 1, temp;
            BigInteger sum = 0;

            Console.Write("{0} ", prev);

            for (int i = 1; i < n; i++)
            {
                Console.Write("{0} ", next);
                sum += next;
                temp = next;
                next += prev;
                prev = temp;
            }

            Console.WriteLine();
            Console.WriteLine("The sum is {0} ", sum);
        }
    }

}