using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.PointWithinCircle
{
    class PointWithinCircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            double distanceFromCentre = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            bool isInside = distanceFromCentre <= 5;

            Console.WriteLine("The podouble ({0};{1}) is inside the circle K(0,5) : {2}", x, y, isInside);
        }
    }
}
