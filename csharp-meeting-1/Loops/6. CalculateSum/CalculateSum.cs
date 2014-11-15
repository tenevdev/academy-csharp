using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _6.CalculateSum
{
    class CalculateSum
    {

        static void Main(string[] args)
        {
            //S = 1 + 1!/X + 2!/X^2 + … + N!/X^N
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());

            double sum = 1;
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                sum += fact / Math.Pow(x, i);
            }

            Console.WriteLine(sum);
        }
    }
}
