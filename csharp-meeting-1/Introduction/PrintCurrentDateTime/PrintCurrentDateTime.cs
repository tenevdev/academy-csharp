using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class PrintCurrentDateTime
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now);
            Thread.Sleep(1000);
        }
    }
}
