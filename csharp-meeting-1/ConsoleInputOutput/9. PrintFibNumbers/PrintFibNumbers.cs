using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PrintFibNumbers
{
    class PrintFibNumbers
    {
        static void Main(string[] args)
        {
            BigInteger first = 1, next = 1, temp;
            Console.WriteLine(first);
            Console.WriteLine(next);
            for (int i = 0; i < 98; i++)
            {
                Console.WriteLine(first + next);
                temp = next;
                next += first;
                first = temp;
            }
        }
    }
}
