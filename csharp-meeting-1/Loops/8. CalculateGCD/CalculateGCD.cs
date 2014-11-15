using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.CalculateGCD
{
    class CalculateGCD
    {

        static int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {   
                return GCD(b, a % b);
            }
        }

        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()),
                b = int.Parse(Console.ReadLine());

            // Recursive
            Console.WriteLine("Recursive -> {0}", GCD(a, b));

            // Loops
            int reminder = 0;
            while (b != 0)
            {
                reminder = b;
                b = a % b;
                a = reminder;
            }

            Console.WriteLine("Loops -> {0}", Math.Abs(a));
        }


    }
}
