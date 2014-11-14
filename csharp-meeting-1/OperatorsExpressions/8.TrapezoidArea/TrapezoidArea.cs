using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            Console.Write("Input a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Input b:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Input h:");
            int h = int.Parse(Console.ReadLine());

            double area = (a + b) * h / 2;
            Console.WriteLine("The area of a trapezoid with sides {0} and {1} and height {2} is {3}", a, b, h, area);
        }
    }
}
