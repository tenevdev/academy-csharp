using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.PointPosition
{
    class PointPosition
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            // k(1;1 , 3) IN
            //rect (1;-1 , 6, 2) OUT

            // distance from 1;1 to x;y
            double distance = Math.Sqrt(Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)); // should be less than or equal to 3

            bool isInside = distance <= 3 && (y > 1 || x < -1); // over the rect or on its left side
            Console.WriteLine("The point is inside the permitted area : {0}", isInside);
        }
    }
}
