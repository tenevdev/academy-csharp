using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitValue
{
    class BitValue
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int mask = 1 << 3; // ..000 1000
            int bitValue = (number & mask) >> 3; // 1 or 0
            Console.WriteLine("The bit in third position is {0}", bitValue);
        }
    }
}
