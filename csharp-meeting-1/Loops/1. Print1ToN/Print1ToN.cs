using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print1ToN
{
    class Print1ToN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i < n + 1; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
