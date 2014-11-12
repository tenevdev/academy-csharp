using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SwapGreaterInteger
{
    class SwapGreaterInteger
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            if (first > second)
            {
                int temp = first;
                first = second;
                second = first;

            }
            Console.WriteLine("{0} and {1}", first, second);
        }
    }
}
