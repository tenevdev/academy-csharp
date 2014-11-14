using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.RectangleArea
{
    class RectangleArea
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int area = width * height;
            Console.WriteLine("The area of a rectangle with sides {0} and {1} is {2}", height, width, area);
        }
    }
}
