using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BitValueInPosition
{
    class BitValueInPosition
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
            bool isOne = bit == 1;

            Console.WriteLine("The value of the bit at {0} in {1} is 1 : {2}", position, number, isOne);
            Console.WriteLine();
        }
    }
}
