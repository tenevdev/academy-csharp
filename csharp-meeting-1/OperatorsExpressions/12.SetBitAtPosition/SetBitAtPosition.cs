using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.SetBitAtPosition
{
    class SetBitAtPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Input bit value: ");
            int bit = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Input bit position: ");
            int position = int.Parse(Console.ReadLine());

            int mask = bit == 0 ? ~(1 << position) : (1 << position);
            int result = bit == 0 ? number & mask : number | mask;

            Console.WriteLine("The result is {0}", result);
        }
    }
}
