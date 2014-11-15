using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print1ToNNotDividedBy21
{
    class Print1ToNNotDividedBy21
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i < n + 1; i++)
            {
                if (i % 21 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
