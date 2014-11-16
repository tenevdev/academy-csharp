using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.GetMaxMethod
{
    class GetMaxMethod
    {
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            return b;
        }
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            int max = GetMax(GetMax(a, b), c);
            Console.WriteLine("Max = {0}", max);
        }
    }
}
