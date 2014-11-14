using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.DynamicExchangeBits
{
    class DynamicExchangeBits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a program that exchanges bits\n{p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1}\nof given 32-bit unsigned integer.");

            Console.Write("Input number : ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("Input p : ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Input q : ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Input k : ");
            int k = int.Parse(Console.ReadLine());

            if (Math.Abs(p - q) >= k && p > 0 && q > 0 && p + k - 1 < 32 && q + k - 1 < 32)
            {
                uint binaryPositions = (uint)Math.Pow(2, k) - 1;
                uint first = (number >> p) & (binaryPositions);
                uint second = (number >> q) & (binaryPositions);

                uint firstMask = (uint)(binaryPositions << p);
                uint secondMask = (uint)(binaryPositions << q);

                uint result = number & ~firstMask | (second << p);
                result = result & ~secondMask | (first << q);

                Console.WriteLine("The r is {0}", result);
            }

            else
            {
                Console.WriteLine("Invalid input");
            }

        }
    }
}
