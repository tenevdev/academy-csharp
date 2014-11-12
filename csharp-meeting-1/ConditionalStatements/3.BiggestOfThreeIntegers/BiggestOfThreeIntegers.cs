using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOfThreeIntegers
{
    class BiggestOfThreeIntegers
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            if (first >= second)
            {
                if(first >= third)
                {
                    Console.WriteLine(first.ToString());
                }
                else
                {
                    Console.WriteLine(third.ToString());
                }
            }
            else if (second >= third)
            {
                Console.WriteLine(second.ToString());
            }
            else
            {
                Console.WriteLine(third.ToString());
            }
        }
    }
}
