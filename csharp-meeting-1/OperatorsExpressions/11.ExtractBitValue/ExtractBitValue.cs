using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ExtractBitValue
{
    class ExtractBitValue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Input bit position: ");
            int position = int.Parse(Console.ReadLine());

            int mask = 1 << position;
            int bit = (number & mask) >> position;

            Console.WriteLine("The value of the bit at {0} in {1} is {2}", position, number, bit);
            Console.WriteLine();
        }
    }
}
