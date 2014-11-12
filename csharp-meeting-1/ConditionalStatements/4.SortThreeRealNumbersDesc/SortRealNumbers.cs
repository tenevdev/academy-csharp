using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.SortThreeRealNumbersDesc
{
    class SortRealNumbers
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine(first.ToString());
                }
                else
                {
                    Console.WriteLine(third.ToString());
                }
            }
            if (second > third)
            {
                Console.WriteLine(second);
                if (first > third)
                {
                    Console.WriteLine(first);
                    Console.WriteLine(third);
                }
                else
                {
                    Console.WriteLine(third);
                    Console.WriteLine(first);
                }
            }
            else
            {
                Console.WriteLine(third);
                Console.WriteLine(second);
                Console.WriteLine(first);
            }
        }
    }
}
