using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintSequence
{
    static void Main(string[] args)
    {
        for (int i = 2; i < 12; i++)
        {
            Console.Write("{0} ", i * Math.Pow(-1, i));
        }
        Console.WriteLine();
    }
}

