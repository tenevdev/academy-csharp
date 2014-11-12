using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintOneToN
{
    class PrintOneToN
    {
        static void Main(string[] args)
        {
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
