using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.QuadraticEquation
{
    class Quadraticequation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double det = b * b - 4 * a * c;
            if (det > 0)
            {
                Console.WriteLine("{0} / {1}", ((-b + Math.Sqrt(det)) / (2 * a)).ToString(), ((-b - Math.Sqrt(det)) / (2 * a)).ToString());
            }
            else if (det == 0)
            {
                Console.WriteLine((-b / (2 * a)).ToString());
            }
            else
            {
                Console.WriteLine("No real roots");
            }
        }
    }
}
