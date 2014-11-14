using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OddOrEven
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string type = number % 2 == 0 ? "even" : "odd";
            Console.WriteLine("The number {0} is {1}", number, type);
        }
    }
}
