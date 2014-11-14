using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ExchangeBits
{
    class ExchangeBits
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());

            uint firstPack = (number >> 3) & 7; // remove first 3 digits and keep next 3 (7 = 111) 
            uint secondPack = (number >> 24) & 7; // remove first 24 digits and keep next 3

            uint firstMask = 7 << 3; // ...000 111 000
            uint secondMask = 7 << 24; // ..00 111 followed by 24 zeros

            uint result = number & ~firstMask | (secondPack << 3); // remove bits with mask and set them with the given value
            result = result & ~secondMask | (firstPack << 24);

            Console.WriteLine("The result is {0}", result);
        }
    }
}
